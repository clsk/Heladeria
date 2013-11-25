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
    public partial class FormMain : BaseForm
    {
        public FormMain(Form previousForm) : base(previousForm)
        {
            InitializeComponent();

            // Get open cajas
            CajaHelper cajaHelper = new CajaHelper();
            List<Caja> cajasAbiertas = cajaHelper.GetAllCajasAbiertasDeEmpleado(App.CurrentUser.empleado_id);
            if (cajasAbiertas.Count > 0)
            {
                MessageBox.Show("Usted tiene una Caja abierta.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _caja = cajasAbiertas[0];
                cajaHelper.Attach(_caja);
                btnCaja.Text = "Abrir Caja";
            }
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            App.CurrentUser = null;
            this.Close();
        }

        private Caja _caja;

        private void btnCaja_Click(object sender, EventArgs e)
        {
            if (_caja == null)
            {
                DialogEfectivoCaja dialog = new DialogEfectivoCaja();
                dialog.Location = this.Location;
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    return;
                }

                CajaHelper cajaHelper = new CajaHelper();
                _caja = cajaHelper.AbrirCaja(App.CurrentUser, dialog.Efectivo);
                dialog.Dispose();
            }

            FormCaja frmCaja = new FormCaja(this, _caja);
            frmCaja.Location = this.Location;
            this.Hide();
            frmCaja.Show();
        }

        private void btOrdenes_Click(object sender, EventArgs e)
        {
            FormViewOrders frmOrders = new FormViewOrders(this);
            frmOrders.Location = this.Location;
            this.Hide();
            frmOrders.Show();
        }
    }
}
