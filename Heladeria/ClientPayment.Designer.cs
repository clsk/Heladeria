namespace Heladeria
{
    partial class ClientPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientPayment));
            this.dgvFacturar = new System.Windows.Forms.DataGridView();
            this.ArtCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbInfoPago = new System.Windows.Forms.GroupBox();
            this.tbResto = new System.Windows.Forms.TextBox();
            this.tbMontoPagar = new System.Windows.Forms.TextBox();
            this.cbFormaDePago = new System.Windows.Forms.ComboBox();
            this.lbResto = new System.Windows.Forms.Label();
            this.lbMethodOfPayment = new System.Windows.Forms.Label();
            this.lbMontoPendiente = new System.Windows.Forms.Label();
            this.lbMontoRecibido = new System.Windows.Forms.Label();
            this.tbMontoRecibido = new System.Windows.Forms.TextBox();
            this.plLogotype = new System.Windows.Forms.Panel();
            this.tbItbis = new System.Windows.Forms.TextBox();
            this.lbItbis = new System.Windows.Forms.Label();
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturar)).BeginInit();
            this.gbInfoPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFacturar
            // 
            this.dgvFacturar.AllowUserToAddRows = false;
            this.dgvFacturar.AllowUserToDeleteRows = false;
            this.dgvFacturar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ArtCode,
            this.Description,
            this.Amount,
            this.UnitPrice,
            this.Total});
            this.dgvFacturar.Location = new System.Drawing.Point(333, 146);
            this.dgvFacturar.Name = "dgvFacturar";
            this.dgvFacturar.ReadOnly = true;
            this.dgvFacturar.RowHeadersVisible = false;
            this.dgvFacturar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvFacturar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacturar.Size = new System.Drawing.Size(684, 334);
            this.dgvFacturar.TabIndex = 13;
            // 
            // ArtCode
            // 
            this.ArtCode.Frozen = true;
            this.ArtCode.HeaderText = "Cod. Art.";
            this.ArtCode.Name = "ArtCode";
            this.ArtCode.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.Frozen = true;
            this.Description.HeaderText = "Descripción";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Description.Width = 280;
            // 
            // Amount
            // 
            this.Amount.Frozen = true;
            this.Amount.HeaderText = "Cant.";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // UnitPrice
            // 
            this.UnitPrice.Frozen = true;
            this.UnitPrice.HeaderText = "Precio Unidad";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.Frozen = true;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // gbInfoPago
            // 
            this.gbInfoPago.Controls.Add(this.tbResto);
            this.gbInfoPago.Controls.Add(this.tbMontoPagar);
            this.gbInfoPago.Controls.Add(this.cbFormaDePago);
            this.gbInfoPago.Controls.Add(this.lbResto);
            this.gbInfoPago.Controls.Add(this.lbMethodOfPayment);
            this.gbInfoPago.Controls.Add(this.lbMontoPendiente);
            this.gbInfoPago.Controls.Add(this.lbMontoRecibido);
            this.gbInfoPago.Controls.Add(this.tbMontoRecibido);
            this.gbInfoPago.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoPago.Location = new System.Drawing.Point(12, 146);
            this.gbInfoPago.Name = "gbInfoPago";
            this.gbInfoPago.Size = new System.Drawing.Size(304, 419);
            this.gbInfoPago.TabIndex = 12;
            this.gbInfoPago.TabStop = false;
            this.gbInfoPago.Text = "Información del Pago";
            // 
            // tbResto
            // 
            this.tbResto.Location = new System.Drawing.Point(58, 337);
            this.tbResto.Multiline = true;
            this.tbResto.Name = "tbResto";
            this.tbResto.ReadOnly = true;
            this.tbResto.Size = new System.Drawing.Size(227, 70);
            this.tbResto.TabIndex = 9;
            // 
            // tbMontoPagar
            // 
            this.tbMontoPagar.Location = new System.Drawing.Point(58, 222);
            this.tbMontoPagar.Multiline = true;
            this.tbMontoPagar.Name = "tbMontoPagar";
            this.tbMontoPagar.ReadOnly = true;
            this.tbMontoPagar.Size = new System.Drawing.Size(227, 70);
            this.tbMontoPagar.TabIndex = 8;
            // 
            // cbFormaDePago
            // 
            this.cbFormaDePago.FormattingEnabled = true;
            this.cbFormaDePago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta"});
            this.cbFormaDePago.Location = new System.Drawing.Point(58, 44);
            this.cbFormaDePago.Name = "cbFormaDePago";
            this.cbFormaDePago.Size = new System.Drawing.Size(227, 25);
            this.cbFormaDePago.TabIndex = 1;
            this.cbFormaDePago.SelectedIndexChanged += new System.EventHandler(this.cbFormaDePago_SelectedIndexChanged);
            // 
            // lbResto
            // 
            this.lbResto.AutoSize = true;
            this.lbResto.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResto.Location = new System.Drawing.Point(8, 317);
            this.lbResto.Name = "lbResto";
            this.lbResto.Size = new System.Drawing.Size(52, 17);
            this.lbResto.TabIndex = 7;
            this.lbResto.Text = "Resto:";
            // 
            // lbMethodOfPayment
            // 
            this.lbMethodOfPayment.AutoSize = true;
            this.lbMethodOfPayment.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMethodOfPayment.Location = new System.Drawing.Point(8, 21);
            this.lbMethodOfPayment.Name = "lbMethodOfPayment";
            this.lbMethodOfPayment.Size = new System.Drawing.Size(111, 17);
            this.lbMethodOfPayment.TabIndex = 2;
            this.lbMethodOfPayment.Text = "Forma de Pago:";
            // 
            // lbMontoPendiente
            // 
            this.lbMontoPendiente.AutoSize = true;
            this.lbMontoPendiente.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMontoPendiente.Location = new System.Drawing.Point(8, 202);
            this.lbMontoPendiente.Name = "lbMontoPendiente";
            this.lbMontoPendiente.Size = new System.Drawing.Size(111, 17);
            this.lbMontoPendiente.TabIndex = 6;
            this.lbMontoPendiente.Text = "Monto A Pagar:";
            // 
            // lbMontoRecibido
            // 
            this.lbMontoRecibido.AutoSize = true;
            this.lbMontoRecibido.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMontoRecibido.Location = new System.Drawing.Point(8, 96);
            this.lbMontoRecibido.Name = "lbMontoRecibido";
            this.lbMontoRecibido.Size = new System.Drawing.Size(119, 17);
            this.lbMontoRecibido.TabIndex = 3;
            this.lbMontoRecibido.Text = "Monto Recibido:";
            // 
            // tbMontoRecibido
            // 
            this.tbMontoRecibido.Location = new System.Drawing.Point(58, 116);
            this.tbMontoRecibido.Multiline = true;
            this.tbMontoRecibido.Name = "tbMontoRecibido";
            this.tbMontoRecibido.ReadOnly = true;
            this.tbMontoRecibido.Size = new System.Drawing.Size(227, 70);
            this.tbMontoRecibido.TabIndex = 4;
            this.tbMontoRecibido.TextChanged += new System.EventHandler(this.tbMontoRecibido_TextChanged_1);
            // 
            // plLogotype
            // 
            this.plLogotype.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plLogotype.BackgroundImage")));
            this.plLogotype.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.plLogotype.Location = new System.Drawing.Point(12, 12);
            this.plLogotype.Name = "plLogotype";
            this.plLogotype.Size = new System.Drawing.Size(274, 128);
            this.plLogotype.TabIndex = 11;
            // 
            // tbItbis
            // 
            this.tbItbis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbItbis.Location = new System.Drawing.Point(878, 496);
            this.tbItbis.Multiline = true;
            this.tbItbis.Name = "tbItbis";
            this.tbItbis.ReadOnly = true;
            this.tbItbis.Size = new System.Drawing.Size(139, 20);
            this.tbItbis.TabIndex = 16;
            this.tbItbis.Text = "RD$ 0.00";
            this.tbItbis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbItbis
            // 
            this.lbItbis.AutoSize = true;
            this.lbItbis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbItbis.Location = new System.Drawing.Point(826, 499);
            this.lbItbis.Name = "lbItbis";
            this.lbItbis.Size = new System.Drawing.Size(45, 17);
            this.lbItbis.TabIndex = 15;
            this.lbItbis.Text = "ITBIS:";
            // 
            // dtpFechaVenta
            // 
            this.dtpFechaVenta.Enabled = false;
            this.dtpFechaVenta.Location = new System.Drawing.Point(333, 120);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(270, 20);
            this.dtpFechaVenta.TabIndex = 14;
            // 
            // ClientPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1034, 581);
            this.Controls.Add(this.tbItbis);
            this.Controls.Add(this.lbItbis);
            this.Controls.Add(this.dtpFechaVenta);
            this.Controls.Add(this.dgvFacturar);
            this.Controls.Add(this.gbInfoPago);
            this.Controls.Add(this.plLogotype);
            this.Name = "ClientPayment";
            this.Text = "ClientPayment";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturar)).EndInit();
            this.gbInfoPago.ResumeLayout(false);
            this.gbInfoPago.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFacturar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.GroupBox gbInfoPago;
        private System.Windows.Forms.TextBox tbResto;
        private System.Windows.Forms.TextBox tbMontoPagar;
        private System.Windows.Forms.ComboBox cbFormaDePago;
        private System.Windows.Forms.Label lbResto;
        private System.Windows.Forms.Label lbMethodOfPayment;
        private System.Windows.Forms.Label lbMontoPendiente;
        private System.Windows.Forms.Label lbMontoRecibido;
        private System.Windows.Forms.TextBox tbMontoRecibido;
        private System.Windows.Forms.Panel plLogotype;
        private System.Windows.Forms.TextBox tbItbis;
        private System.Windows.Forms.Label lbItbis;
        private System.Windows.Forms.DateTimePicker dtpFechaVenta;
    }
}