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
    public partial class DialogSuplidores : Form
    {
        public DialogSuplidores()
        {
            InitializeComponent();
            SuplidorHelper suplidorHelper = new SuplidorHelper();
            _suplidores = suplidorHelper.GetAll();
            cbSuplidores.DataSource = _suplidores;
            cbSuplidores.DisplayMember = "nombre";

        }

        private void btSeleccionar_Click(object sender, EventArgs e)
        {
            if (cbSuplidores.SelectedItem != null)
            {
                SelectedSuplidor = (Suplidor)cbSuplidores.SelectedItem;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult result = MessageBox.Show("Seleccione un Suplidor. Si desea cancelar la operacion, haga click en Cancelar", "Ningun Suplidor Seleccionado!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Cancel)
                {
                    this.DialogResult = DialogResult.Cancel;
                }
                return;
            }
        }

        public Suplidor SelectedSuplidor
        {
            get;
            private set;
        }
        private List<Suplidor> _suplidores;
    }
}
