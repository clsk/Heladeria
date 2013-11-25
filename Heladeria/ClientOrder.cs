﻿using System;
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
        private static ClientOrder _instance;

        public static ClientOrder GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ClientOrder();
                }
                return _instance;
            }
        }
        
        static List<DataGridViewRow> SelectedProducts = new List<DataGridViewRow>();

        public ClientOrder()
        {
            InitializeComponent();
        }

        private void ClientOrder_Load(object sender, EventArgs e)
        {
            
        }

        public void AddSelectedProduct(DataGridViewRow OneSelected)
        {
            string _idAux = "";
            _idAux = OneSelected.Cells["CodigoArticulo"].Value.ToString();

            if (!ExistProduct(_idAux))
            {
                SelectedProducts.Add(OneSelected);                
            }
            else {
                System.Windows.Forms.MessageBox.Show("Este producto ya existe en la lista.", "ERROR", MessageBoxButtons.OK);
            }
        }

        private bool ExistProduct(string _idProduct) {
            int i = 0;
            bool _exist = false;
            string _idAux = "";

            if (SelectedProducts.Count > 0) {
                while (i < SelectedProducts.Count)
                {
                    _idAux = SelectedProducts.ElementAt(i).Cells["CodigoArticulo"].Value.ToString();
                    if (_idAux == _idProduct)
                    {
                        _exist = true;
                        break;
                    }
                    i++;
                }
            }

            return _exist;
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
                    }
                    i++;
                }
            }
        }

        private void PlaceOrder() {
            int i = 0;
            DataGridViewRow _row = new DataGridViewRow();
            SelectedProducts.Clear();

            while (i < dgvPedidoProductos.RowCount)
            {
                _row = dgvPedidoProductos.Rows[i];
                SelectedProducts.Add(_row);
                i++;
            }        
        }

        private void btnAgregarProducto_Click_1(object sender, EventArgs e)
        {
            if (SelectedProducts.Count != dgvPedidoProductos.RowCount)
            {
                ReadDataGridView();
            }
            ProductsListSales _productsSales = new ProductsListSales();
            _productsSales.ShowDialog();
            ShowInDGV();
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            SelectedProducts.Clear();
            tbItbis.Text = "0.00";
            tbMontoTotal.Text = "0.00";
            tbSubTotal.Text = "0.00";
            dgvPedidoProductos.RowCount = 0;
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            SelectedProducts.Clear();
            dgvPedidoProductos.RowCount = 0;
            this.Close();
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            if (dgvPedidoProductos.RowCount > 0)
            {
                int i = 0;
                int cant = 0;
                double precio = 0;
                int CantRows = dgvPedidoProductos.RowCount;
                DataGridViewRow _row = new DataGridViewRow();

                while (i < CantRows)
                {
                    _row = dgvPedidoProductos.Rows[i];
                    cant = int.Parse((_row.Cells["CantidadArticulos"].Value.ToString()));
                    precio = Convert.ToDouble(_row.Cells["PrecioUnitarioArt"].Value.ToString());
                    if (cant > 1)
                    {
                        _row.Cells["PreciosTotalArt"].Value = (precio * cant).ToString();
                    }
                    i++;
                }

                /*Actualizacion de Totales de Venta*/
                double _sub = 0;
                double _desc = 0;
                double _itbis = 0;
                double _total = 0;
                i = 0;

                while (i < dgvPedidoProductos.RowCount)
                {
                    _sub += Convert.ToDouble(dgvPedidoProductos.Rows[i].Cells["PreciosTotalArt"].Value.ToString());
                    i++;
                }

                _itbis = _sub * 0.18;
                _total = (_itbis + _sub) - _desc;

                tbSubTotal.Text = "RD$ " + _sub.ToString();
                tbItbis.Text = "RD$ " + _itbis.ToString();
                tbMontoTotal.Text = "RD$ " + _total.ToString();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("No es posible actualizar la tabla.", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void btnProcesar_Click_1(object sender, EventArgs e)
        {
            if (dgvPedidoProductos.RowCount > 0)
            {
                ReadDataGridView();
                PlaceOrder();
                Heladeria.ClientPayment _payToMe = new Heladeria.ClientPayment();
                _payToMe.SetProductsOrder(SelectedProducts);
                _payToMe.ShowDialog();
                this.Close();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("No existen Productos Seleccionados.", "ERROR", MessageBoxButtons.OK);
            }
        }
    }
}
