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
            try
            {
                empleado = Empleados.Login(tbCorreo.Text, tbClave.Text);

                if (empleado == null)
                {
                    MessageBox.Show("No se pudo validar el usuario", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(DataLayer.Utils.CalculateMD5Hash("MyPass123"));
                }
                else
                {
                    MessageBox.Show("Usuario Autenticado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
