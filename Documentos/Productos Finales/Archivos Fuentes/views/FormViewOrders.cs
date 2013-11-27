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
            List<Orden> ordenes = ordenHelper.GetAll("recibida is null OR recibida = 0");
            _ordenes = new List<OrdenView>();
            foreach (Orden orden in ordenes)
            {
                _ordenes.Add(new OrdenView(orden));
            }

            dgvOrdenes.DataSource = _ordenes;
        }

        List<OrdenView> _ordenes;

        public void AddOrden(Orden orden)
        {
            _ordenes.Add(new OrdenView(orden));
            dgvOrdenes.DataSource = null;
            dgvOrdenes.DataSource = _ordenes;
        }

        private void btNuevaOrden_Click(object sender, EventArgs e)
        {
            DialogSuplidores dialog = new DialogSuplidores();
            dialog.Location = this.Location;
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.Cancel)
                return;


            FormNewOrden frmNewOrden = new FormNewOrden(this, dialog.SelectedSuplidor);
            frmNewOrden.Location = this.Location;
            this.Hide();
            frmNewOrden.Show();
        }

        private void btVerOrden_Click(object sender, EventArgs e)
        {
            if (dgvOrdenes.SelectedRows.Count > 0)
            {
                OrdenView selectedOrden = _ordenes[dgvOrdenes.SelectedRows[0].Index];
                FormNewOrden frmNewOrden = new FormNewOrden(this, selectedOrden.Orden);
                frmNewOrden.Location = this.Location;
                this.Hide();
                frmNewOrden.Show();
            }
        }

        private void btCancelarOrden_Click(object sender, EventArgs e)
        {
            if (dgvOrdenes.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Esta seguro que desea Cancelar esta orden?\n", "Confirmar Cancelacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Cancel)
                {
                    return;
                }

                OrdenView selectedOrden = _ordenes[dgvOrdenes.SelectedRows[0].Index];
                OrdenHelper helper = new OrdenHelper();
                helper.RemoveOrden(selectedOrden.Orden.orden_id);
                _ordenes.RemoveAt(dgvOrdenes.SelectedRows[0].Index);
                dgvOrdenes.DataSource = null;
                dgvOrdenes.DataSource = _ordenes;
            }
        }
    }
}
