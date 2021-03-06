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
    public partial class DialogSupervisor : Form
    {
        public DialogSupervisor()
        {
            InitializeComponent();
            btCancel.DialogResult = DialogResult.Cancel;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
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

            this.DialogResult = DialogResult.OK;
        }
    }
}
