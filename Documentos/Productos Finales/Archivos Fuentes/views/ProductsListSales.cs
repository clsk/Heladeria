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
            decimal _unitprice;
            string _price;

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
                    if (OneProduct.nombre != "Delivery")
                        _DetailDescription += " Etiqueta Tradicional";
                }

                if (OneProduct.precio_venta.HasValue && OneProduct.precio_venta.Value > 0)
                {
                    _unitprice = OneProduct.precio_venta.Value;
                }
                else
                {
                    _unitprice = 0;
                }

                _price = string.Format("{0:0.00}", _unitprice);
                dgvListaProductos.Rows.Add(num, OneProduct.producto_id, _DetailDescription, _price);
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
