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
    public partial class DialogCuadreCaja : Form
    {
        public DialogCuadreCaja()
        {
            InitializeComponent();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            EmpleadosHelper empleadosHelper = new EmpleadosHelper();
            Empleado supervisor = empleadosHelper.Login(tbCorreo.Text, tbClave.Text);
            if (supervisor.cargo != "supervisor")
            {
                MessageBox.Show("Solor un supervisor puede darle permiso a ingresar al sistema fuera de horario", "Este usuario no es un supervisor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Supervisor = supervisor;
            try
            {
                EfectivoSalida = Decimal.Parse(tbEfectivo.Text);
            }
            catch (Exception ex)
            {
                if (DialogResult.Cancel == MessageBox.Show(ex.ToString(), "Error de entrada en Cantidad Efectivo!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error))
                {
                    this.DialogResult = DialogResult.Cancel;
                }

                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        public decimal EfectivoSalida
        {
            get;
            private set;
        }

        public Empleado Supervisor
        {
            get;
            private set;
        }
    }
}
