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
    public partial class CreditCard : BaseForm
    {
        string FourDigits;

        public CreditCard (Form previousForm) : base (previousForm)
        {
            InitializeComponent();
        }

        private void cbTipoTarjeta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoTarjeta.SelectedItem.ToString() == "Master Card" || cbTipoTarjeta.SelectedItem.ToString() == "Visa")
            {
                tbSegCod.MaxLength = 3;
            }
            if (cbTipoTarjeta.SelectedItem.ToString() == "American Express")
            {
                tbSegCod.MaxLength = 4;
            }
        }

        private void mtbTarjetaNo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Numero de Tarjeta Erroneo.", "ERROR", MessageBoxButtons.OK);
            mtbTarjetaNo.Clear();
        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            int _mes = int.Parse(cbMonth.SelectedItem.ToString());
            int _sysmes = DateTime.Now.Month;
            int _sysanio = DateTime.Now.Year;
            int _anio = int.Parse(cbYear.SelectedItem.ToString());

            if (_mes < _sysmes && _anio < _sysanio)
            {
                System.Windows.Forms.MessageBox.Show("Fecha de Expiración Incorrecta.", "ERROR", MessageBoxButtons.OK);
                cbYear.Text = _sysanio.ToString();
                cbMonth.Text = _sysmes.ToString();
            }
        }

        private void tbSegCod_TextChanged(object sender, EventArgs e)
        {
            int _secure = 0;

            if (int.TryParse(tbSegCod.Text.ToString(), out _secure))
            {
                tbSegCod.Text = _secure.ToString();
            }
            else
            {
                tbSegCod.Text = "000";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            mtbTarjetaNo.Text = "";
            tbSegCod.Text = "";   
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string _cardNum;
            _cardNum = mtbTarjetaNo.Text.ToString().Substring(15, 4);
            FourDigits = _cardNum;
            this.Hide();
        }

        public string GetCardNumber()
        {
            return FourDigits;
        }

        private void FormCreditCard_Load(object sender, EventArgs e)
        {
            int _sysmes = DateTime.Now.Month;
            int _sysanio = DateTime.Now.Year;
            cbMonth.SelectedItem = _sysmes.ToString();
            cbYear.SelectedItem = _sysanio.ToString();
        }
    }
}
