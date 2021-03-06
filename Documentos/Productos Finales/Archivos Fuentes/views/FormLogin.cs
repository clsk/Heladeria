﻿using System;
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

                TurnoHelper turnoHelper = new TurnoHelper();
                empleado.Turno = turnoHelper.Get(empleado.turno_id.Value);

                // Find out if within Turno
                DateTime currentDate = DateTime.Now;
                int dayOfWeek = (int)Math.Pow(2, ((int)currentDate.DayOfWeek) + 1);
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
                    dialog.Location = this.Location;
                    DialogResult result = dialog.ShowDialog();
                    dialog.Dispose();
                    if (result == DialogResult.Cancel)
                    {
                        return;
                    }
                }
                // Good to go! Take user to MainForm
                App.CurrentUser = empleado;
                FormMain frmMain = new FormMain(this);
                frmMain.Location = this.Location;
                this.Hide();
                frmMain.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
