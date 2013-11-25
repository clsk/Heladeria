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
    public partial class FormNewOrden : BaseForm
    {
        private Suplidor _suplidor;
        public FormNewOrden(Form previousForm, Suplidor suplidor) : base(previousForm)
        {
            InitializeComponent();
            _suplidor = suplidor;
            ProductosHelper productoHelper = new ProductosHelper();
            List<Producto> productos = productoHelper.GetAll("suplidor = " + suplidor.suplidor_id);
            List<ProductoOrden> productosSuplidor = new List<ProductoOrden>(productos.Count);
            foreach (Producto producto in productos)
            {
                productosSuplidor.Add(new ProductoOrden(producto));
            }

            _productos = productosSuplidor;
            dgvProductos.DataSource = _productos;

        }

        public FormNewOrden(Form previousForm, List<ProductoOrden> productos)
            : base(previousForm)
        {
            InitializeComponent();
            _productos = productos;
            dgvProductos.DataSource = _productos;
        }

        private List<ProductoOrden> _productos;

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btOrdenar_Click(object sender, EventArgs e)
        {
            List<ProductoOrden> toBuy = new List<ProductoOrden>();
            foreach (ProductoOrden producto in _productos)
            {
                if (producto.Ordenar && producto.Cantidad > 0)
                {
                    toBuy.Add(producto);
                }
            }

            if (toBuy.Count == 0)
            {
                DialogResult result = MessageBox.Show("No a seleccionado ningun articulo para ordenar", "Error!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Cancel)
                {
                    this.Close();
                }

                return;
            }

            OrdenHelper ordenHelper = new OrdenHelper();
            Orden orden = ordenHelper.CrearOrden(App.CurrentUser.empleado_id, 3, toBuy);


            // TODO:
            // Show summary
            // Make sure new order is added to open orders dgv


        }

        private decimal CalcularTotal()
        {
            decimal total = 0;
            foreach (ProductoOrden producto in _productos)
            {
                if (producto.Ordenar && producto.Cantidad > 0)
                {
                    total += (producto.PrecioCompra * producto.Cantidad);
                }
            }

            return total;
        }

        private void dgvProductos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            tbTotal.Text = CalcularTotal().ToString();
        }
    }
}
