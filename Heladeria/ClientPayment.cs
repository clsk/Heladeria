using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heladeria
{
    public partial class ClientPayment : Form
    {
        public ClientPayment()
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

            _itbis = _mntPagar * 0.18;
            _mntPagar += _itbis;

            tbMontoPagar.Text = _mntPagar.ToString();
            tbItbis.Text = _itbis.ToString();
        }

        private void ClientPayment_Load(object sender, EventArgs e)
        {
            UploadData();
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
            }
        }

        private void tbMontoRecibido_TextChanged_1(object sender, EventArgs e)
        {
            double _Pago;
            double _Pagar;
            double _resto;

            if (double.TryParse(tbMontoRecibido.Text.ToString(), out _Pagar))
            {
                _Pago = Convert.ToDouble(tbMontoPagar.Text.ToString());
                _resto = _Pagar - _Pago;
                tbResto.Text = _resto.ToString();
            }
            else
            {
                tbMontoRecibido.Text = "0.00";
            }
        }
    }
}
