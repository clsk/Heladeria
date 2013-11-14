namespace Reportes
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.btGetReport = new System.Windows.Forms.Button();
            this.rptViewerVentas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpVentas = new System.Windows.Forms.TabPage();
            this.tpOfertas = new System.Windows.Forms.TabPage();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.tpCaja = new System.Windows.Forms.TabPage();
            this.rptViewerOfertas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbImpuestos = new System.Windows.Forms.TabPage();
            this.cbEmpleados = new System.Windows.Forms.ComboBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.dtpCaja = new System.Windows.Forms.DateTimePicker();
            this.lblFechaCaja = new System.Windows.Forms.Label();
            this.btCaja = new System.Windows.Forms.Button();
            this.rptCaja = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpHastaImpuestos = new System.Windows.Forms.DateTimePicker();
            this.rptImpuestos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtpDesdeImpuestos = new System.Windows.Forms.DateTimePicker();
            this.btImpuestos = new System.Windows.Forms.Button();
            this.tbCashSalida = new System.Windows.Forms.TextBox();
            this.lblCashSalida = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tpVentas.SuspendLayout();
            this.tpOfertas.SuspendLayout();
            this.tpCaja.SuspendLayout();
            this.tbImpuestos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(284, 24);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpDesde.TabIndex = 0;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(586, 24);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(212, 20);
            this.dtpHasta.TabIndex = 1;
            // 
            // btGetReport
            // 
            this.btGetReport.Location = new System.Drawing.Point(444, 79);
            this.btGetReport.Name = "btGetReport";
            this.btGetReport.Size = new System.Drawing.Size(142, 45);
            this.btGetReport.TabIndex = 2;
            this.btGetReport.Text = "Obtener Reporte";
            this.btGetReport.UseVisualStyleBackColor = true;
            this.btGetReport.Click += new System.EventHandler(this.btGetReport_Click);
            // 
            // rptViewerVentas
            // 
            this.rptViewerVentas.Location = new System.Drawing.Point(6, 154);
            this.rptViewerVentas.Name = "rptViewerVentas";
            this.rptViewerVentas.Size = new System.Drawing.Size(1090, 424);
            this.rptViewerVentas.TabIndex = 3;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpVentas);
            this.tabControl.Controls.Add(this.tpOfertas);
            this.tabControl.Controls.Add(this.tpCaja);
            this.tabControl.Controls.Add(this.tbImpuestos);
            this.tabControl.Location = new System.Drawing.Point(2, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1113, 610);
            this.tabControl.TabIndex = 4;
            // 
            // tpVentas
            // 
            this.tpVentas.Controls.Add(this.lblHasta);
            this.tpVentas.Controls.Add(this.lblDesde);
            this.tpVentas.Controls.Add(this.dtpHasta);
            this.tpVentas.Controls.Add(this.rptViewerVentas);
            this.tpVentas.Controls.Add(this.dtpDesde);
            this.tpVentas.Controls.Add(this.btGetReport);
            this.tpVentas.Location = new System.Drawing.Point(4, 22);
            this.tpVentas.Name = "tpVentas";
            this.tpVentas.Padding = new System.Windows.Forms.Padding(3);
            this.tpVentas.Size = new System.Drawing.Size(1105, 584);
            this.tpVentas.TabIndex = 0;
            this.tpVentas.Text = "Ventas";
            this.tpVentas.UseVisualStyleBackColor = true;
            // 
            // tpOfertas
            // 
            this.tpOfertas.Controls.Add(this.rptViewerOfertas);
            this.tpOfertas.Location = new System.Drawing.Point(4, 22);
            this.tpOfertas.Name = "tpOfertas";
            this.tpOfertas.Padding = new System.Windows.Forms.Padding(3);
            this.tpOfertas.Size = new System.Drawing.Size(1105, 584);
            this.tpOfertas.TabIndex = 1;
            this.tpOfertas.Text = "Ofertas";
            this.tpOfertas.UseVisualStyleBackColor = true;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(350, 8);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(38, 13);
            this.lblDesde.TabIndex = 4;
            this.lblDesde.Text = "Desde";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(674, 8);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(35, 13);
            this.lblHasta.TabIndex = 5;
            this.lblHasta.Text = "Hasta";
            // 
            // tpCaja
            // 
            this.tpCaja.Controls.Add(this.lblCashSalida);
            this.tpCaja.Controls.Add(this.tbCashSalida);
            this.tpCaja.Controls.Add(this.rptCaja);
            this.tpCaja.Controls.Add(this.btCaja);
            this.tpCaja.Controls.Add(this.lblFechaCaja);
            this.tpCaja.Controls.Add(this.dtpCaja);
            this.tpCaja.Controls.Add(this.lblEmpleado);
            this.tpCaja.Controls.Add(this.cbEmpleados);
            this.tpCaja.Location = new System.Drawing.Point(4, 22);
            this.tpCaja.Name = "tpCaja";
            this.tpCaja.Size = new System.Drawing.Size(1105, 584);
            this.tpCaja.TabIndex = 2;
            this.tpCaja.Text = "Cuadre Caja";
            this.tpCaja.UseVisualStyleBackColor = true;
            // 
            // rptViewerOfertas
            // 
            this.rptViewerOfertas.Location = new System.Drawing.Point(0, 0);
            this.rptViewerOfertas.Name = "rptViewerOfertas";
            this.rptViewerOfertas.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.rptViewerOfertas.ServerReport.ReportPath = "/TestProject/Ofertas";
            this.rptViewerOfertas.Size = new System.Drawing.Size(1105, 588);
            this.rptViewerOfertas.TabIndex = 0;
            // 
            // tbImpuestos
            // 
            this.tbImpuestos.Controls.Add(this.label1);
            this.tbImpuestos.Controls.Add(this.label2);
            this.tbImpuestos.Controls.Add(this.dtpHastaImpuestos);
            this.tbImpuestos.Controls.Add(this.rptImpuestos);
            this.tbImpuestos.Controls.Add(this.dtpDesdeImpuestos);
            this.tbImpuestos.Controls.Add(this.btImpuestos);
            this.tbImpuestos.Location = new System.Drawing.Point(4, 22);
            this.tbImpuestos.Name = "tbImpuestos";
            this.tbImpuestos.Size = new System.Drawing.Size(1105, 584);
            this.tbImpuestos.TabIndex = 3;
            this.tbImpuestos.Text = "Impuestos";
            this.tbImpuestos.UseVisualStyleBackColor = true;
            // 
            // cbEmpleados
            // 
            this.cbEmpleados.AllowDrop = true;
            this.cbEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpleados.FormattingEnabled = true;
            this.cbEmpleados.Location = new System.Drawing.Point(137, 36);
            this.cbEmpleados.Name = "cbEmpleados";
            this.cbEmpleados.Size = new System.Drawing.Size(183, 21);
            this.cbEmpleados.TabIndex = 0;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(62, 39);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(54, 13);
            this.lblEmpleado.TabIndex = 1;
            this.lblEmpleado.Text = "Empleado";
            // 
            // dtpCaja
            // 
            this.dtpCaja.Location = new System.Drawing.Point(459, 36);
            this.dtpCaja.Name = "dtpCaja";
            this.dtpCaja.Size = new System.Drawing.Size(212, 20);
            this.dtpCaja.TabIndex = 2;
            // 
            // lblFechaCaja
            // 
            this.lblFechaCaja.AutoSize = true;
            this.lblFechaCaja.Location = new System.Drawing.Point(400, 39);
            this.lblFechaCaja.Name = "lblFechaCaja";
            this.lblFechaCaja.Size = new System.Drawing.Size(37, 13);
            this.lblFechaCaja.TabIndex = 3;
            this.lblFechaCaja.Text = "Fecha";
            // 
            // btCaja
            // 
            this.btCaja.Location = new System.Drawing.Point(425, 90);
            this.btCaja.Name = "btCaja";
            this.btCaja.Size = new System.Drawing.Size(142, 45);
            this.btCaja.TabIndex = 4;
            this.btCaja.Text = "Obtener Reporte";
            this.btCaja.UseVisualStyleBackColor = true;
            this.btCaja.Click += new System.EventHandler(this.btCaja_Click);
            // 
            // rptCaja
            // 
            this.rptCaja.Location = new System.Drawing.Point(6, 160);
            this.rptCaja.Name = "rptCaja";
            this.rptCaja.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.rptCaja.ServerReport.ReportServerUrl = new System.Uri("", System.UriKind.Relative);
            this.rptCaja.Size = new System.Drawing.Size(1090, 424);
            this.rptCaja.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(675, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Desde";
            // 
            // dtpHastaImpuestos
            // 
            this.dtpHastaImpuestos.Location = new System.Drawing.Point(587, 23);
            this.dtpHastaImpuestos.Name = "dtpHastaImpuestos";
            this.dtpHastaImpuestos.Size = new System.Drawing.Size(212, 20);
            this.dtpHastaImpuestos.TabIndex = 7;
            // 
            // rptImpuestos
            // 
            this.rptImpuestos.Location = new System.Drawing.Point(7, 153);
            this.rptImpuestos.Name = "rptImpuestos";
            this.rptImpuestos.Size = new System.Drawing.Size(1090, 424);
            this.rptImpuestos.TabIndex = 9;
            // 
            // dtpDesdeImpuestos
            // 
            this.dtpDesdeImpuestos.Location = new System.Drawing.Point(285, 23);
            this.dtpDesdeImpuestos.Name = "dtpDesdeImpuestos";
            this.dtpDesdeImpuestos.Size = new System.Drawing.Size(200, 20);
            this.dtpDesdeImpuestos.TabIndex = 6;
            // 
            // btImpuestos
            // 
            this.btImpuestos.Location = new System.Drawing.Point(445, 78);
            this.btImpuestos.Name = "btImpuestos";
            this.btImpuestos.Size = new System.Drawing.Size(142, 45);
            this.btImpuestos.TabIndex = 8;
            this.btImpuestos.Text = "Obtener Reporte";
            this.btImpuestos.UseVisualStyleBackColor = true;
            this.btImpuestos.Click += new System.EventHandler(this.btImpuestos_Click);
            // 
            // tbCashSalida
            // 
            this.tbCashSalida.Location = new System.Drawing.Point(871, 29);
            this.tbCashSalida.MaxLength = 10;
            this.tbCashSalida.Name = "tbCashSalida";
            this.tbCashSalida.Size = new System.Drawing.Size(111, 20);
            this.tbCashSalida.TabIndex = 6;
            this.tbCashSalida.Text = "0.00";
            this.tbCashSalida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCashSalida
            // 
            this.lblCashSalida.AutoSize = true;
            this.lblCashSalida.Location = new System.Drawing.Point(770, 36);
            this.lblCashSalida.Name = "lblCashSalida";
            this.lblCashSalida.Size = new System.Drawing.Size(63, 13);
            this.lblCashSalida.TabIndex = 7;
            this.lblCashSalida.Text = "Cash Salida";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 615);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tpVentas.ResumeLayout(false);
            this.tpVentas.PerformLayout();
            this.tpOfertas.ResumeLayout(false);
            this.tpCaja.ResumeLayout(false);
            this.tpCaja.PerformLayout();
            this.tbImpuestos.ResumeLayout(false);
            this.tbImpuestos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Button btGetReport;
        private Microsoft.Reporting.WinForms.ReportViewer rptViewerVentas;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpVentas;
        private System.Windows.Forms.TabPage tpOfertas;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.TabPage tpCaja;
        private Microsoft.Reporting.WinForms.ReportViewer rptViewerOfertas;
        private System.Windows.Forms.TabPage tbImpuestos;
        private System.Windows.Forms.ComboBox cbEmpleados;
        private Microsoft.Reporting.WinForms.ReportViewer rptCaja;
        private System.Windows.Forms.Button btCaja;
        private System.Windows.Forms.Label lblFechaCaja;
        private System.Windows.Forms.DateTimePicker dtpCaja;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpHastaImpuestos;
        private Microsoft.Reporting.WinForms.ReportViewer rptImpuestos;
        private System.Windows.Forms.DateTimePicker dtpDesdeImpuestos;
        private System.Windows.Forms.Button btImpuestos;
        private System.Windows.Forms.Label lblCashSalida;
        private System.Windows.Forms.TextBox tbCashSalida;
    }
}

