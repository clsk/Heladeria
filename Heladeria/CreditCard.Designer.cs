namespace Heladeria
{
    partial class CreditCard
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mtbTarjetaNo = new System.Windows.Forms.MaskedTextBox();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.lbTipoTarjeta = new System.Windows.Forms.Label();
            this.tbSegCod = new System.Windows.Forms.TextBox();
            this.cbTipoTarjeta = new System.Windows.Forms.ComboBox();
            this.lbSecCod = new System.Windows.Forms.Label();
            this.lbNoTarjeta = new System.Windows.Forms.Label();
            this.lbFechaExp = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Green;
            this.btnGuardar.Location = new System.Drawing.Point(466, 165);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(91, 28);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Red;
            this.btnReset.Location = new System.Drawing.Point(12, 165);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(91, 28);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mtbTarjetaNo);
            this.panel1.Controls.Add(this.cbYear);
            this.panel1.Controls.Add(this.cbMonth);
            this.panel1.Controls.Add(this.lbTipoTarjeta);
            this.panel1.Controls.Add(this.tbSegCod);
            this.panel1.Controls.Add(this.cbTipoTarjeta);
            this.panel1.Controls.Add(this.lbSecCod);
            this.panel1.Controls.Add(this.lbNoTarjeta);
            this.panel1.Controls.Add(this.lbFechaExp);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 147);
            this.panel1.TabIndex = 11;
            // 
            // mtbTarjetaNo
            // 
            this.mtbTarjetaNo.Location = new System.Drawing.Point(106, 64);
            this.mtbTarjetaNo.Mask = "0000-0000-0000-0000";
            this.mtbTarjetaNo.Name = "mtbTarjetaNo";
            this.mtbTarjetaNo.Size = new System.Drawing.Size(334, 20);
            this.mtbTarjetaNo.TabIndex = 13;
            this.mtbTarjetaNo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbTarjetaNo_MaskInputRejected);
            // 
            // cbYear
            // 
            this.cbYear.AutoCompleteCustomSource.AddRange(new string[] {
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023"});
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Items.AddRange(new object[] {
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023"});
            this.cbYear.Location = new System.Drawing.Point(156, 112);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(63, 21);
            this.cbYear.TabIndex = 12;
            this.cbYear.SelectedIndexChanged += new System.EventHandler(this.cbYear_SelectedIndexChanged);
            // 
            // cbMonth
            // 
            this.cbMonth.AutoCompleteCustomSource.AddRange(new string[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cbMonth.Location = new System.Drawing.Point(106, 112);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(44, 21);
            this.cbMonth.TabIndex = 11;
            this.cbMonth.SelectedIndexChanged += new System.EventHandler(this.cbMonth_SelectedIndexChanged);
            // 
            // lbTipoTarjeta
            // 
            this.lbTipoTarjeta.AutoSize = true;
            this.lbTipoTarjeta.Location = new System.Drawing.Point(18, 21);
            this.lbTipoTarjeta.Name = "lbTipoTarjeta";
            this.lbTipoTarjeta.Size = new System.Drawing.Size(82, 13);
            this.lbTipoTarjeta.TabIndex = 0;
            this.lbTipoTarjeta.Text = "Tipo de Tarjeta:";
            // 
            // tbSegCod
            // 
            this.tbSegCod.Location = new System.Drawing.Point(340, 112);
            this.tbSegCod.Name = "tbSegCod";
            this.tbSegCod.Size = new System.Drawing.Size(100, 20);
            this.tbSegCod.TabIndex = 7;
            this.tbSegCod.TextChanged += new System.EventHandler(this.tbSegCod_TextChanged);
            // 
            // cbTipoTarjeta
            // 
            this.cbTipoTarjeta.FormattingEnabled = true;
            this.cbTipoTarjeta.Items.AddRange(new object[] {
            "Master Card",
            "Visa",
            "American Express"});
            this.cbTipoTarjeta.Location = new System.Drawing.Point(106, 18);
            this.cbTipoTarjeta.Name = "cbTipoTarjeta";
            this.cbTipoTarjeta.Size = new System.Drawing.Size(154, 21);
            this.cbTipoTarjeta.TabIndex = 1;
            this.cbTipoTarjeta.SelectedIndexChanged += new System.EventHandler(this.cbTipoTarjeta_SelectedIndexChanged);
            // 
            // lbSecCod
            // 
            this.lbSecCod.AutoSize = true;
            this.lbSecCod.Location = new System.Drawing.Point(225, 115);
            this.lbSecCod.Name = "lbSecCod";
            this.lbSecCod.Size = new System.Drawing.Size(109, 13);
            this.lbSecCod.TabIndex = 6;
            this.lbSecCod.Text = "Código de Seguridad:";
            // 
            // lbNoTarjeta
            // 
            this.lbNoTarjeta.AutoSize = true;
            this.lbNoTarjeta.Location = new System.Drawing.Point(18, 67);
            this.lbNoTarjeta.Name = "lbNoTarjeta";
            this.lbNoTarjeta.Size = new System.Drawing.Size(60, 13);
            this.lbNoTarjeta.TabIndex = 2;
            this.lbNoTarjeta.Text = "No. Tarjeta";
            // 
            // lbFechaExp
            // 
            this.lbFechaExp.AutoSize = true;
            this.lbFechaExp.Location = new System.Drawing.Point(18, 115);
            this.lbFechaExp.Name = "lbFechaExp";
            this.lbFechaExp.Size = new System.Drawing.Size(64, 13);
            this.lbFechaExp.TabIndex = 4;
            this.lbFechaExp.Text = "Fecha Exp.:";
            // 
            // FormCreditCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 204);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCreditCard";
            this.Text = "FormCreditCard";
            this.Load += new System.EventHandler(this.FormCreditCard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox mtbTarjetaNo;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.Label lbTipoTarjeta;
        private System.Windows.Forms.TextBox tbSegCod;
        private System.Windows.Forms.ComboBox cbTipoTarjeta;
        private System.Windows.Forms.Label lbSecCod;
        private System.Windows.Forms.Label lbNoTarjeta;
        private System.Windows.Forms.Label lbFechaExp;
    }
}