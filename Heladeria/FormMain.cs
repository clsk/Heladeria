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
    public partial class FormMain : BaseForm
    {
        public FormMain(Form previousForm) : base(previousForm)
        {
            InitializeComponent();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            App.CurrentUser = null;
            this.Close();
        }
    }
}
