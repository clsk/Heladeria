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

        public FormNewOrden(Form previousForm, Orden orden) 
            : base(previousForm)
        {
            InitializeComponent();

            Orden_ProductosHelper helper = new Orden_ProductosHelper();
            ProductosHelper productoHelper = new ProductosHelper();
            List<Orden_Productos> ordenProductos = helper.GetAllFromOrden(orden.orden_id);
            _productos = new List<ProductoOrden>();
            foreach (Orden_Productos ordenProducto in ordenProductos)
            {
                Producto producto = productoHelper.Get(ordenProducto.producto_id);
                ProductoOrden productoOrden = new ProductoOrden(producto);
                productoOrden.Cantidad = ordenProducto.cantidad;
                productoOrden.Ordenar = true;
                _productos.Add(productoOrden);
            }
            dgvProductos.ReadOnly = true;
            dgvProductos.DataSource = _productos;
            dgvProductos_CellEndEdit(null, null);
            btCancelar.Hide();
            btOrdenar.Hide();
        }


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

            DialogResult dialogResult = MessageBox.Show("Su total es de " + tbTotal.Text + ".\nDesea completar la Orden?", "Confirme Orden", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Cancel)
            {
                return;
            }

            OrdenHelper ordenHelper = new OrdenHelper();
            Orden orden = ordenHelper.CrearOrden(App.CurrentUser.empleado_id, _suplidor.suplidor_id, toBuy);
            MessageBox.Show("Su Orden ha sido completada.", "Orden Completada Existosamente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ((FormViewOrders)base._previousForm).AddOrden(orden);
            this.Close();
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
            tbTotal.Text = "RD$" + CalcularTotal().ToString();
        }

        private List<ProductoOrden> _productos;
        private Suplidor _suplidor;
    }
}
