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
    public partial class ProductsListSales : Form
    {
        public delegate void AllSelectedProducts(DataGridViewRow _selected);

        public event AllSelectedProducts AddProducts;

        public DataGridViewRow SelectedRow = new DataGridViewRow();
        
        public ProductsListSales()
        {
            InitializeComponent();
        }

        private void ListadoDeProductos_Load(object sender, EventArgs e)
        {
            /*
             * TODO:
             *  Aqui iria la parte logica que se conecta con la base de datos.
             *  Solo para cargar los productos.
             */
            var _Productos = Logica.Productos.GetAllProducts();

            int num = 1;
            foreach (var OneProduct in _Productos)
            {
                dgvListaProductos.Rows.Add(num, OneProduct.ProductID, OneProduct.ProductName, OneProduct.UnitsPrice);
                num++;
            }

            _Productos.Clear();
        }

        private void dgvListaProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SelectedRow = dgvListaProductos.Rows[e.RowIndex];

                if (SelectedRow.Selected)
                    this.AddProducts(SelectedRow);
                else
                    System.Windows.Forms.MessageBox.Show("No es posible agregar el producto.", "ERROR", MessageBoxButtons.OK);
            }
        }
    }
}
