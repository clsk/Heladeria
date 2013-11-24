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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Empleado empleado;
            EmpleadosHelper empleadoHelper = new EmpleadosHelper();
            try
            {

                empleado = empleadoHelper.Login(tbCorreo.Text, tbClave.Text);
                tbClave.Clear();
                if (empleado == null)
                {
                    MessageBox.Show("No se pudo validar el usuario", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                TurnoHelper productoHelper = new TurnoHelper();
                empleado.Turno = productoHelper.Get(empleado.turno_id.Value);

                // Find out if within Turno
                DateTime currentDate = DateTime.Now;
                int dayOfWeek = (int) Math.Pow(((int)currentDate.DayOfWeek) +1,2);
                if (empleado.cargo != "supervisor" || ((empleado.Turno.dias & dayOfWeek) != dayOfWeek) 
                    && (currentDate.TimeOfDay < empleado.Turno.hora_comienza && currentDate.TimeOfDay > empleado.Turno.hora_termina ))
                {

                    // If not, request supervisor approval
                    if (MessageBox.Show("Usted esta tratando de ingresar en un horario que no le corresponde.\n Por lo tanto necesita aprobacion de su supervisor.\n", "Necesita Aprobacion de un Supervisor", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                        == DialogResult.Cancel)
                    {
                        return;
                    }

                    DialogSupervisor dialog = new DialogSupervisor();
                    DialogResult result = dialog.ShowDialog();
                    if (result == DialogResult.Cancel)
                    {
                        return;
                    }
                    else if (result == DialogResult.Abort)
                    {
                        MessageBox.Show("Solor un supervisor puede darle permiso a ingresar al sistema fuera de horario", "Este usuario no es un supervisor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                // Good to go! Take user to MainForm
                App.CurrentUser = empleado;
                this.Hide();
                FormMain frmMain = new FormMain(this);
                frmMain.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
