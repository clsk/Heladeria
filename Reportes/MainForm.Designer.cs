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
            this.tp = new System.Windows.Forms.TabPage();
            this.rptViewerOfertas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabControl.SuspendLayout();
            this.tpVentas.SuspendLayout();
            this.tpOfertas.SuspendLayout();
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
            this.tabControl.Controls.Add(this.tp);
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
            // tp
            // 
            this.tp.Location = new System.Drawing.Point(4, 22);
            this.tp.Name = "tp";
            this.tp.Size = new System.Drawing.Size(1105, 584);
            this.tp.TabIndex = 2;
            this.tp.Text = "tabPage1";
            this.tp.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.TabPage tp;
        private Microsoft.Reporting.WinForms.ReportViewer rptViewerOfertas;
    }
}

