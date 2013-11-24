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
            CajaHelper cajaHelper = new CajaHelper();
            _caja = cajaHelper.AbrirCaja(App.CurrentUser, 10000.00m);
            MessageBox.Show(_caja.caja_id.ToString());
        }
    }
}
