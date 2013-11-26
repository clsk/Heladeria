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
    public partial class ProductsListSales : BaseForm
    {
        public ProductsListSales (Form previousForm) : base (previousForm)
        {
            InitializeComponent();
            string _DetailDescription;

            ProductosHelper _ProductosHelp = new ProductosHelper();
            var _Productos = _ProductosHelp.GetAllProductosParaVenta();

            int num = 1;
            foreach (var OneProduct in _Productos)
            {
                _DetailDescription = OneProduct.nombre;

                if (OneProduct.etiqueta_negra.HasValue && OneProduct.etiqueta_negra.Value)
                {
                    _DetailDescription += " Etiqueta Negra";
                }
                else
                {
                    _DetailDescription += " Etiqueta Tradicional";
                }

                dgvListaProductos.Rows.Add(num, OneProduct.producto_id, _DetailDescription, OneProduct.precio_venta);
                num++;
            }

            _Productos.Clear();
        }

        private void dgvListaProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow _row = new DataGridViewRow();

                _row = dgvListaProductos.Rows[e.RowIndex];

                ClientOrder _venta = ClientOrder.GetInstance;
                _venta.AddSelectedProduct(_row);
            }
            this.Close();
        }
    }
}
