using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;

namespace Heladeria
{
    public partial class ClientOrder : BaseForm
    {
        private static ClientOrder _instance;

        public static ClientOrder GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ClientOrder ();
                }
                return _instance;
            }
        }
        
        static List<DataGridViewRow> SelectedProducts = new List<DataGridViewRow>();

        public ClientOrder(Form previousForm) : base (previousForm)
        {
            InitializeComponent();
        }

        private ClientOrder () { 
        
        }

        private void ClientOrder_Load(object sender, EventArgs e)
        {
            
        }

        public void AddSelectedProduct(DataGridViewRow OneSelected)
        {
            string _idAux = "";
            _idAux = OneSelected.Cells["CodigoArticulo"].Value.ToString();
            string _productName;

            if (!ExistProduct(_idAux))
            {
                _productName = OneSelected.Cells["DescripcionArticulo"].Value.ToString();
                if (_productName == "Delivery")
                {
                    ClientsRecord frmPerfilClientes = new ClientsRecord(this);
                    frmPerfilClientes.ShowDialog();
                    ClienteID = frmPerfilClientes.GetClienteID();
                    frmPerfilClientes.Close();
                }
                SelectedProducts.Add(OneSelected);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Este producto ya existe en la lista.", "ERROR", MessageBoxButtons.OK);
            }
        }

        private bool ExistProduct(string _idProduct) {
            int i = 0;
            bool _exist = false;
            string _idAux = "";

            if (SelectedProducts.Count > 0)
            {
                while (i < SelectedProducts.Count)
                {
                    _idAux = SelectedProducts.ElementAt(i).Cells["CodigoArticulo"].Value.ToString();
                    if (_idAux == _idProduct)
                    {
                        _exist = true;
                        break;
                    }
                    i++;
                }
            }
            return _exist;
        }

        private void ShowInDGV()
        {
            dgvPedidoProductos.RowCount = 0;

            int i = 0;

            while (i < SelectedProducts.Count)
            {
                string _id = SelectedProducts.ElementAt(i).Cells["CodigoArticulo"].Value.ToString();
                string _nombre = SelectedProducts.ElementAt(i).Cells["DescripcionArticulo"].Value.ToString();
                string _precio = SelectedProducts.ElementAt(i).Cells["PrecioUnitarioArt"].Value.ToString();
                dgvPedidoProductos.Rows.Add(i + 1, _id, _nombre, 1, _precio, _precio);
                i++;
            }          
        }

        private void ReadDataGridView()
        {
            int i = 0;
            int CantRows = dgvPedidoProductos.RowCount;
            DataGridViewRow _row = new DataGridViewRow();

            if (CantRows > 0)
            {
                while (i < CantRows)
                {
                    _row = dgvPedidoProductos.Rows[i];
                    if (_row.Cells["CodigoArticulo"].Value.ToString() != SelectedProducts.ElementAt(i).Cells["CodigoArticulo"].Value.ToString())
                    {
                        SelectedProducts.Remove(SelectedProducts.ElementAt(i));
                    }
                    i++;
                }
            }
        }

        private void PlaceOrder() {
            int i = 0;
            DataGridViewRow _row = new DataGridViewRow();
            SelectedProducts.Clear();

            while (i < dgvPedidoProductos.RowCount)
            {
                _row = dgvPedidoProductos.Rows[i];
                SelectedProducts.Add(_row);
                i++;
            }           
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (SelectedProducts.Count != dgvPedidoProductos.RowCount)
            {
                ReadDataGridView();
            }
            ProductsListSales _productsSales = new ProductsListSales(this);
            _productsSales.ShowDialog();
            ShowInDGV();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            SelectedProducts.Clear();
            tbItbis.Text = "0.00";
            tbMontoTotal.Text = "0.00";
            tbSubTotal.Text = "0.00";
            dgvPedidoProductos.RowCount = 0;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            SelectedProducts.Clear();
            dgvPedidoProductos.RowCount = 0;
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvPedidoProductos.RowCount > 0)
            {
                int i = 0;
                int cant = 0;
                double precio = 0;
                int CantRows = dgvPedidoProductos.RowCount;
                DataGridViewRow _row = new DataGridViewRow();

                while (i < CantRows)
                {
                    _row = dgvPedidoProductos.Rows[i];
                    cant = int.Parse((_row.Cells["CantidadArticulos"].Value.ToString()));
                    precio = Convert.ToDouble(_row.Cells["PrecioUnitarioArt"].Value.ToString());
                    if (cant > 1)
                    {
                        string _idAux = "";
                        _idAux = _row.Cells["CodigoArticulo"].Value.ToString();

                        OfertasHelper _ofertas = new OfertasHelper();
                        Oferta _ThisOffert = new Oferta();

                        _ThisOffert = _ofertas.Get("producto_id", int.Parse(_idAux));

                        if (_ThisOffert != null)
                        {
                            DateTime _today = DateTime.Now;
                            int _ThisDay = (int)_today.DayOfWeek;
                            int available = (int)Math.Pow(2, _ThisDay);

                            if (((_ThisOffert.dias_disponible & available) != available) && (_today.TimeOfDay < _ThisOffert.hora_disponible_termina)
                                    && (_today.TimeOfDay > _ThisOffert.hora_disponible_empieza) && (_today.Date < _ThisOffert.fecha_termina)
                                    && (_today.Date > _ThisOffert.fecha_empieza))
                            {
                                if (cant % 2 == 0)
                                {
                                    string _NomOferta = _ThisOffert.nombre;
                                    _row.Cells["DescripcionArticulo"].Value = _NomOferta;
                                    cant = cant / 2;
                                }
                            }
                        }
                    }
                    _row.Cells["PreciosTotalArt"].Value = (precio * cant).ToString();
                    i++;
                }

                /*Actualizacion de Totales de Venta*/
                double _sub = 0;
                double _itbis = 0;
                double _total = 0;
                i = 0;

                while (i < dgvPedidoProductos.RowCount)
                {
                    _sub += Convert.ToDouble(dgvPedidoProductos.Rows[i].Cells["PreciosTotalArt"].Value.ToString());
                    i++;
                }

                _itbis = _sub * 0.18;
                _total = (_itbis + _sub);

                tbSubTotal.Text = "RD$ " + string.Format("{0:0.00}", _sub);
                tbItbis.Text = "RD$ " + string.Format("{0:0.00}", _itbis);
                tbMontoTotal.Text = "RD$ " + string.Format("{0:0.00}", _total);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("No es posible actualizar la tabla.", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            if (dgvPedidoProductos.RowCount > 0)
            {
                ReadDataGridView();
                PlaceOrder();
                ClientPayment _payToMe = new ClientPayment(this);
                _payToMe.SetProductsOrder(SelectedProducts, ClienteID);
                _payToMe.ShowDialog();
                this.Close();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("No existen Productos Seleccionados.", "ERROR", MessageBoxButtons.OK);
            }
        }

        public void CleanClientOrder()
        {
            SelectedProducts.Clear();
            dgvPedidoProductos.RowCount = 0;
        }
        
        public int GetCajaNumber() {
            return ((FormCaja)base._previousForm).GetCajaID();
        }
    }
}