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

                if (empleado == null)
                {
                    MessageBox.Show("No se pudo validar el usuario", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Usuario Autenticado!");
                    TurnoHelper productoHelper = new TurnoHelper();
                    empleado.Turno = productoHelper.Get(empleado.turno_id.Value);

                    // Find out if within Turno
                    DateTime currentDate = DateTime.Now;
                    int dayOfWeek = (int) Math.Pow(((int)currentDate.DayOfWeek) +1,2);
                    if (empleado.Turno != null && ((empleado.Turno.dias & dayOfWeek) == dayOfWeek))
                    {
                        MessageBox.Show("OK!");
                    }
                    else
                    {
                        MessageBox.Show("Need Supervisor Approval");
                    }
                    // If not, request supervisor approval

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
