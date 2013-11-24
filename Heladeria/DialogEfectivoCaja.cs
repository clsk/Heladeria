using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heladeria
{
    public partial class DialogEfectivoCaja : Form
    {
        public DialogEfectivoCaja()
        {
            InitializeComponent();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            Efectivo = Decimal.Parse(tbEfectivo.Text);
        }

        public decimal Efectivo
        {
            get;
            private set;
        }
    }
}
