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
    public partial class FormRegistroInventario : BaseForm
    {
        public FormRegistroInventario(Form previousForm) : base(previousForm)
        {
            InitializeComponent();

            ProductosHelper helper = new ProductosHelper();
            List<Producto> productos = helper.GetAll();
            _productos = new List<ProductoInventario>();
            foreach (Producto producto in productos)
            {
                _productos.Add(new ProductoInventario(producto));
            }

            dgvInventario.DataSource = _productos;
        }

        private List<ProductoInventario> _productos;

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAplicar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Esta seguro que desea realizar estos Cambios al Inventario?", "Confirmar Cambios", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Cancel)
            {
                return;
            }

            List<ProductoInventario> toModify = new List<ProductoInventario>();
            foreach (ProductoInventario producto in _productos)
            {
                if (producto.ModificarCantidad)
                {
                    toModify.Add(producto);
                }
            }

            if (toModify.Count == 0)
            {
                DialogResult result = MessageBox.Show("No a modificado ningun producto.", "Error!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Cancel)
                {
                    this.Close();
                }

                return;
            }

            RegistroInventarioHelper registroHelper = new RegistroInventarioHelper();
            RegistroInventario registro = registroHelper.CrearRegistro(App.CurrentUser.empleado_id, toModify);
            MessageBox.Show("Su cambios han sido registrados.", "Cambios Registrados Existosamente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
