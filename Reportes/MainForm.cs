using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Collections;
using DataLayer;

namespace Reportes
{
    public partial class MainForm : Form
    {
        private BindingSource _empleadosBinding;
        public MainForm()
        {
            InitializeComponent();
        }

        private void btGetReport_Click(object sender, EventArgs e)
        {
            try
            {
                string urlReportServer = "http://localhost//Reportserver";
                rptViewerVentas.ProcessingMode = ProcessingMode.Remote; // ProcessingMode will be Either Remote or Local
                rptViewerVentas.ServerReport.ReportServerUrl = new Uri(urlReportServer); //Set the ReportServer Url
                rptViewerVentas.ServerReport.ReportPath = "/TestProject/Ventas"; //Passing the Report Path                

                ReportParameter[] param = new ReportParameter[2];
                param[0] = new ReportParameter("fecha_empieza", dtpDesde.Value.ToShortDateString());
                param[1] = new ReportParameter("fecha_termina", dtpHasta.Value.ToShortDateString());

                //pass parmeters to report
                rptViewerVentas.ServerReport.SetParameters(param); //Set Report Parameters
                rptViewerVentas.ServerReport.Refresh();
                rptViewerVentas.RefreshReport();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'heladeriaDataSet.Venta' table. You can move, or remove it, as needed.

            this.rpInventario.RefreshReport();
            this.rptViewerOfertas.RefreshReport();

            try
            {
                var empleados = Empleados.GetAll();
                _empleadosBinding = new BindingSource();
                _empleadosBinding.DataSource = empleados;
                cbEmpleados.DataSource = _empleadosBinding;
                cbEmpleados.DisplayMember = "nombre";
                cbEmpleados.ValueMember = "empleado_id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btCaja_Click(object sender, EventArgs e)
        {
            try
            {
                float cash_salida = float.Parse(tbCashSalida.Text);

                string urlReportServer = "http://localhost//Reportserver";
                rptCaja.ProcessingMode = ProcessingMode.Remote; // ProcessingMode will be Either Remote or Local
                rptCaja.ServerReport.ReportServerUrl = new Uri(urlReportServer); //Set the ReportServer Url
                rptCaja.ServerReport.ReportPath = "/TestProject/ReporteCajaCerrada"; //Passing the Report Path                

                ReportParameter[] param = new ReportParameter[3];
                param[0] = new ReportParameter("empleado_id", cbEmpleados.SelectedValue.ToString());
                param[1] = new ReportParameter("fecha", dtpCaja.Value.ToShortDateString());
                param[2] = new ReportParameter("cash_salida", tbCashSalida.Text);

                //pass parmeters to report
                rptCaja.ServerReport.SetParameters(param); //Set Report Parameters
                rptCaja.ServerReport.Refresh();
                rptCaja.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btImpuestos_Click(object sender, EventArgs e)
        {
            try
            {
                string urlReportServer = "http://localhost//Reportserver";
                rptImpuestos.ProcessingMode = ProcessingMode.Remote; // ProcessingMode will be Either Remote or Local
                rptImpuestos.ServerReport.ReportServerUrl = new Uri(urlReportServer); //Set the ReportServer Url
                rptImpuestos.ServerReport.ReportPath = "/TestProject/ReporteComprobantes"; //Passing the Report Path                

                ReportParameter[] param = new ReportParameter[2];

                param[0] = new ReportParameter("fc_desde", dtpDesdeImpuestos.Value.ToShortDateString());
                param[1] = new ReportParameter("fc_hasta", dtpHastaImpuestos.Value.ToShortDateString());

                //pass parmeters to report
                rptImpuestos.ServerReport.SetParameters(param); //Set Report Parameters
                rptImpuestos.ServerReport.Refresh();
                rptImpuestos.RefreshReport();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
