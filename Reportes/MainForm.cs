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
        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowReport()
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

                // pass crendentitilas
                //rptViewer.ServerReport.ReportServerCredentials = 
                //  new ReportServerCredentials("uName", "PassWORD", "doMain");

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

        private void btGetReport_Click(object sender, EventArgs e)
        {
            ShowReport();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'heladeriaDataSet.Venta' table. You can move, or remove it, as needed.

            this.rptViewerVentas.RefreshReport();
            this.rptViewerOfertas.RefreshReport();

            try
            {
                var empleados = Empleados.GetEmpleados();
                cbEmpleados.DataSource = empleados;
                foreach (Empleado empleado in empleados)
                {
                    MessageBox.Show(empleado.nombre + ' ' + empleado.apellido);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
