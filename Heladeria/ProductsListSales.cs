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
    public partial class ProductsListSales
    {

        public ProductsListSales ()
        {
            InitializeComponent();

            ProductosHelper _ProductosHelp = new ProductosHelper();
            var _Productos = _ProductosHelp.GetAllProductosParaVenta();

            int num = 1;
            foreach (var OneProduct in _Productos)
            {
                dgvListaProductos.Rows.Add(num, OneProduct.producto_id, OneProduct.descripcion, OneProduct.precio_venta);
                num++;
            }

            _Productos.Clear();
        }

        private void dgvListaProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow _row = new DataGridViewRow();

                _row = dgvListaProductos.Rows[e.RowIndex];
                ClientOrder _venta = ClientOrder.GetInstance;
                _venta.AddSelectedProduct(_row);
            }
        }
    }
}
