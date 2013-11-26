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
    public partial class ClientPayment : BaseForm
    {
        private string FourDigits;

        List<Tuple<int, int>> _VentaProductoCantidad = new List<Tuple<int, int>>();
        
        public ClientPayment (Form previousForm) : base (previousForm)
        {
            InitializeComponent();
        }

        private List<DataGridViewRow> ProductsOrder = new List<DataGridViewRow>();

        public void SetProductsOrder(List<DataGridViewRow> wishProducts)
        {
            ProductsOrder = wishProducts;
        }

        private void UploadData()
        {
            int i = 0;
            string _id;
            string _nombre;
            string _undPrecio;
            string _tolPrecio;
            string _cant;
            double _mntPagar = 0;
            double _itbis = 0;
            DataGridViewRow _row = new DataGridViewRow();

            while (i < ProductsOrder.Count)
            {
                _id = ProductsOrder.ElementAt(i).Cells["CodigoArticulo"].Value.ToString();
                _nombre = ProductsOrder.ElementAt(i).Cells["DescripcionArticulo"].Value.ToString();
                _undPrecio = ProductsOrder.ElementAt(i).Cells["PrecioUnitarioArt"].Value.ToString();
                _tolPrecio = ProductsOrder.ElementAt(i).Cells["PreciosTotalArt"].Value.ToString();
                _cant = ProductsOrder.ElementAt(i).Cells["CantidadArticulos"].Value.ToString();
                dgvFacturar.Rows.Add(_id, _nombre, _cant, _undPrecio, _tolPrecio);
                _mntPagar += (int.Parse(_cant)) * (Convert.ToDouble(_undPrecio));
                i++;
            }


            string _test;

            _itbis = _mntPagar * 0.18;
            _mntPagar += _itbis;

            _test = string.Format("{0:0.00}", _mntPagar);
            tbMontoPagar.Text = _test;

            _test = string.Format("{0:0.00}", _itbis);
            tbItbis.Text = _test;
        }

        private void cbFormaDePago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFormaDePago.SelectedItem.ToString() == "Efectivo")
            {
                tbMontoRecibido.ReadOnly = false;
            }
            else
            {
                tbMontoRecibido.Text = tbMontoPagar.Text;
                double _Pago = Convert.ToDouble(tbMontoPagar.Text.ToString());
                double _Pagar = Convert.ToDouble(tbMontoRecibido.Text.ToString());
                double _resto = _Pagar - _Pago;
                tbResto.Text = _resto.ToString();

                CreditCard _MyCreditCard = new CreditCard(this);
                _MyCreditCard.ShowDialog();
                FourDigits = _MyCreditCard.GetCardNumber();
                _MyCreditCard.Close();
            }
        }

        private void cbIncluirComprobante_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIncluirComprobante.Checked)
            {
                pnlCliente.Visible = true;
            }
            else
            {
                pnlCliente.Visible = false;
            }
        }

        private void mtbNoRNC_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Numero de RNC Erroneo.", "ERROR", MessageBoxButtons.OK);
            mtbNoRNC.Clear();
        }

        private void tbNombreCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            _VentaProductoCantidad.Clear();

            int _productID;
            int _cant;
            int NoCaja = ((ClientOrder)base._previousForm).GetCajaNumber();
            string _payType = cbFormaDePago.SelectedItem.ToString();
            VentaHelper _ThisVenta = new VentaHelper();

            for (int i = 0; i < dgvFacturar.RowCount; i++)
            {
                _productID = int.Parse(dgvFacturar.Rows[i].Cells["ArtCode"].Value.ToString());
                _cant = int.Parse(dgvFacturar.Rows[i].Cells["Amount"].Value.ToString());
                Tuple<int, int> _venta = new Tuple<int, int>(_productID, _cant);
                _VentaProductoCantidad.Add(_venta);
            }
            //int caja_id, string forma_pago, List<Tuple<int, int>> productos, string tarjeta_no = "", int cliente_id = 0

            if (!cbDelivery.Checked)
            {
                if (_payType == "Efectivo")
                {
                    _ThisVenta.CreateVenta(NoCaja, _payType, _VentaProductoCantidad, "", 0);
                    MessageBox.Show("Factura Guardada.", "NOTIFICACION", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    _ThisVenta.CreateVenta(NoCaja, _payType, _VentaProductoCantidad, FourDigits, 0);
                    MessageBox.Show("Factura Guardada.", "NOTIFICACION", MessageBoxButtons.OK);
                    this.Close();
                }
            }
            else
            {
                if (_payType == "Efectivo")
                {
                    _ThisVenta.CreateVenta(NoCaja, _payType, _VentaProductoCantidad, "", 0);
                    MessageBox.Show("Factura Guardada.", "NOTIFICACION", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    _ThisVenta.CreateVenta(NoCaja, _payType, _VentaProductoCantidad, FourDigits, 0);
                    MessageBox.Show("Factura Guardada.", "NOTIFICACION", MessageBoxButtons.OK);
                    this.Close();
                }
            }
        }

        private void ClientPayment_Load(object sender, EventArgs e)
        {
            UploadData();
        }

        private void tbMontoRecibido_TextChanged(object sender, EventArgs e)
        {
            double _Pago;
            double _Pagar;
            double _resto;
            string _text;

            if (double.TryParse(tbMontoRecibido.Text.ToString(), out _Pagar))
            {
                _Pago = Convert.ToDouble(tbMontoPagar.Text.ToString());
                _resto = _Pagar - _Pago;
                _text = string.Format("{0:0.00}", _resto);
                tbResto.Text = _resto.ToString();
            }
            else
            {
                tbMontoRecibido.Text = "0.00";
            }
        }

        private void cbDelivery_CheckedChanged(object sender, EventArgs e)
        {
            ClientsRecord frmClient = new ClientsRecord(this);
            frmClient.Location = this.Location;
            this.Hide();
            frmClient.Show();
        }
    }
}
