using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class ClientOrder : Form
    {
        private ProductsListSales ProductsList = new ProductsListSales();

        private List<DataGridViewRow> SelectedProducts = new List<DataGridViewRow>();        
        
        public ClientOrder()
        {
            InitializeComponent();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            ProductsList.ShowDialog();
            ProductsList.AddProducts += new ProductsListSales.AllSelectedProducts(AddSelectedProduct);
            ProductsList.Close();
        }

        public void AddSelectedProduct(DataGridViewRow OneSelected)
        {
            if (!SelectedProducts.Contains(OneSelected))
            {
                SelectedProducts.Add(OneSelected);
            }
            else {
                System.Windows.Forms.MessageBox.Show("Este producto ya existe en la lista.", "ERROR", MessageBoxButtons.OK);
            }
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
            int cant = 0;
            double precio = 0;
            int CantRows = dgvPedidoProductos.RowCount;
            DataGridViewRow _row = new DataGridViewRow();

            if (CantRows > 0)
            {
                while (i < CantRows)
                {
                    _row = dgvPedidoProductos.Rows[i];
                    if (_row.Cells["CodigoArticulo"].Value != SelectedProducts.ElementAt(i).Cells["CodigoArticulo"].Value)
                    {
                        SelectedProducts.Remove(SelectedProducts.ElementAt(i));
                        cant = Convert.ToInt32(_row.Cells["CantidadArticulos"].Value.ToString());
                        precio = Convert.ToInt32(_row.Cells["PrecioUnitarioArt"].Value.ToString());
                        if (cant > 1)
                        {
                            _row.Cells["PreciosTotalArt"].Value = (precio * cant).ToString();
                        }
                    }
                    i++;
                }
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            ReadDataGridView();
            double _sub = 0;
            double _desc = 0;
            double _itbis = 0;
            double _total = 0;
            int i = 0;

            while (i < SelectedProducts.Count())
            {
                _sub += Convert.ToDouble(SelectedProducts.ElementAt(i).Cells["PrecioUnitarioArt"].Value.ToString());
                i++;
            }

            _itbis = _sub * 0.18;
            _total = (_itbis + _sub) - _desc;

            tbSubTotal.Text = "RD$ " + _sub.ToString();
            tbItbis.Text = "RD$ " + _itbis.ToString();
            tbMontoTotal.Text = "RD$ " + _total.ToString();
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

                if (CantRows > 0)
                {
                    while (i < CantRows)
                    {
                        _row = dgvPedidoProductos.Rows[i];
                        if (_row.Cells["CodigoArticulo"].Value != SelectedProducts.ElementAt(i).Cells["CodigoArticulo"].Value)
                        {
                            SelectedProducts.Remove(SelectedProducts.ElementAt(i));
                            cant = Convert.ToInt32(_row.Cells["CantidadArticulos"].Value.ToString());
                            precio = Convert.ToInt32(_row.Cells["PrecioUnitarioArt"].Value.ToString());
                            if (cant > 1)
                            {
                                _row.Cells["PreciosTotalArt"].Value = (precio * cant).ToString();
                            }
                        }
                        i++;
                    }
                }
            }
            else {
                System.Windows.Forms.MessageBox.Show("No es posible actualizar la tabla", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvPedidoProductos.RowCount = 0;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
