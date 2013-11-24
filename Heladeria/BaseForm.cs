using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heladeria
{
    public class BaseForm : Form
    {
        public BaseForm()
            : base()
        { }

        public BaseForm(Form previousForm)
            : base()
        {
            this._previousForm = previousForm;
            this.FormClosing += OnClose;
        }

        public void OnClose(object sender, FormClosingEventArgs e)
        {
            _previousForm.Show();
        }

        private Form _previousForm;
    }
}
