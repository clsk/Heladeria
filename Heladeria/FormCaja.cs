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
    public partial class FormCaja : BaseForm
    {
        public FormCaja(Form previousForm, Caja caja) : base(previousForm)
        {
            InitializeComponent();
            _caja = caja;
            _cajaHelper = new CajaHelper();
            this.Text = "Caja Abierta Desde " + _caja.fecha_abre.ToString();
            tbEfectivoAbre.Text = _caja.cash_entrada.ToString();
            UpdateVentasEfectivo();
            UpdateVentasTarjeta();
        }

        private void UpdateVentasEfectivo()
        {
            _ventasEfectivo = _cajaHelper.CalcularVentasEfectivo(_caja.caja_id);
            tbVentasEfectivo.Text = _ventasEfectivo.ToString(); 
        }

        private void UpdateVentasTarjeta()
        {
            _ventasTarjeta = _cajaHelper.CalcularVentasTarjeta(_caja.caja_id);
            tbVentasTarjeta.Text = _ventasTarjeta.ToString();
        }

        private void btCuadre_Click(object sender, EventArgs e)
        {
            DialogCuadreCaja dialog = new DialogCuadreCaja();
            dialog.Location = this.Location;
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                return;
            }

            if (dialog.EfectivoSalida - _caja.cash_entrada != 0)
            {
                MessageBox.Show("El balance de la caja no cuadra.\nCuante el efectivo y trate de nuevo\nBalance Actual: " + (dialog.EfectivoSalida - (_caja.cash_entrada + _ventasEfectivo)), "Balance Descuadrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _caja.fecha_cierra = DateTime.Now;
            _caja.autorizador_cierre = dialog.Supervisor.empleado_id;
            _cajaHelper.SaveChanges();
            this.Close();
        }

        public Caja Caja
        {
            get
            {
                return _caja;
            }
        }

        private Caja _caja;
        private CajaHelper _cajaHelper;
        private decimal _ventasEfectivo;
        private decimal _ventasTarjeta;

        private void btVenta_Click(object sender, EventArgs e)
        {
            ClientOrder frmVenta = new ClientOrder(this);
            frmVenta.Location = this.Location;
            frmVenta.CleanClientOrder();
            this.Hide();
            frmVenta.Show();

        }

        public int GetCajaID() {
            return _caja.caja_id;
        }
    }
}
