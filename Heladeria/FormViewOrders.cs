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
    public partial class FormViewOrders : BaseForm
    {
        public FormViewOrders(Form previousForm) : base(previousForm)
        {
            InitializeComponent();

            OrdenHelper ordenHelper = new OrdenHelper();
            List<Orden> ordenes = ordenHelper.GetAll("recibida = 0");
            _ordenes = new List<OrdenView>();
            foreach (Orden orden in ordenes)
            {
                _ordenes.Add(new OrdenView(orden));
            }

            dgvOrdenes.DataSource = _ordenes;
        }

        List<OrdenView> _ordenes;

        private void btNuevaOrden_Click(object sender, EventArgs e)
        {
            FormNewOrden frmNewOrden = new FormNewOrden(this);
            frmNewOrden.Location = this.Location;
            this.Hide();
            frmNewOrden.Show();
        }
    }
}
