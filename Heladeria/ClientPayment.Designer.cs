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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.tbNombreCliente = new System.Windows.Forms.TextBox();
            this.lbNombreCliente = new System.Windows.Forms.Label();
            this.mtbNoRNC = new System.Windows.Forms.MaskedTextBox();
            this.lbRNC = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbLogotipo = new System.Windows.Forms.TextBox();
            this.cbIncluirComprobante = new System.Windows.Forms.CheckBox();
            this.lbSubTotal = new System.Windows.Forms.Label();
            this.tbSubTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturar)).BeginInit();
            this.gbInfoPago.SuspendLayout();
            this.pnlCliente.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.tbMontoRecibido.TextChanged += new System.EventHandler(this.tbMontoRecibido_TextChanged);
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
            this.tbItbis.Location = new System.Drawing.Point(878, 525);
            this.tbItbis.Multiline = true;
            this.tbItbis.Name = "tbItbis";
            this.tbItbis.ReadOnly = true;
            this.tbItbis.Size = new System.Drawing.Size(139, 20);
            this.tbItbis.TabIndex = 16;
            this.tbItbis.Text = "0.00";
            this.tbItbis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbItbis
            // 
            this.lbItbis.AutoSize = true;
            this.lbItbis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbItbis.Location = new System.Drawing.Point(827, 528);
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
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(11, 578);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 38);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFacturar
            // 
            this.btnFacturar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.ForeColor = System.Drawing.Color.Green;
            this.btnFacturar.Location = new System.Drawing.Point(897, 578);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(120, 38);
            this.btnFacturar.TabIndex = 17;
            this.btnFacturar.Text = "FACTURAR";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // pnlCliente
            // 
            this.pnlCliente.Controls.Add(this.tbNombreCliente);
            this.pnlCliente.Controls.Add(this.lbNombreCliente);
            this.pnlCliente.Controls.Add(this.mtbNoRNC);
            this.pnlCliente.Controls.Add(this.lbRNC);
            this.pnlCliente.Location = new System.Drawing.Point(333, 511);
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Size = new System.Drawing.Size(371, 97);
            this.pnlCliente.TabIndex = 20;
            this.pnlCliente.Visible = false;
            // 
            // tbNombreCliente
            // 
            this.tbNombreCliente.Location = new System.Drawing.Point(86, 56);
            this.tbNombreCliente.Name = "tbNombreCliente";
            this.tbNombreCliente.Size = new System.Drawing.Size(267, 20);
            this.tbNombreCliente.TabIndex = 21;
            this.tbNombreCliente.TextChanged += new System.EventHandler(this.tbNombreCliente_TextChanged);
            // 
            // lbNombreCliente
            // 
            this.lbNombreCliente.AutoSize = true;
            this.lbNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreCliente.Location = new System.Drawing.Point(15, 57);
            this.lbNombreCliente.Name = "lbNombreCliente";
            this.lbNombreCliente.Size = new System.Drawing.Size(62, 17);
            this.lbNombreCliente.TabIndex = 20;
            this.lbNombreCliente.Text = "Nombre:";
            // 
            // mtbNoRNC
            // 
            this.mtbNoRNC.Location = new System.Drawing.Point(86, 16);
            this.mtbNoRNC.Mask = "000-0000000-0";
            this.mtbNoRNC.Name = "mtbNoRNC";
            this.mtbNoRNC.Size = new System.Drawing.Size(107, 20);
            this.mtbNoRNC.TabIndex = 19;
            this.mtbNoRNC.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbNoRNC_MaskInputRejected);
            // 
            // lbRNC
            // 
            this.lbRNC.AutoSize = true;
            this.lbRNC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRNC.Location = new System.Drawing.Point(15, 17);
            this.lbRNC.Name = "lbRNC";
            this.lbRNC.Size = new System.Drawing.Size(41, 17);
            this.lbRNC.TabIndex = 18;
            this.lbRNC.Text = "RNC:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbDireccion);
            this.panel1.Controls.Add(this.tbLogotipo);
            this.panel1.Location = new System.Drawing.Point(711, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 119);
            this.panel1.TabIndex = 21;
            // 
            // tbDireccion
            // 
            this.tbDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDireccion.Location = new System.Drawing.Point(17, 60);
            this.tbDireccion.Multiline = true;
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.ReadOnly = true;
            this.tbDireccion.Size = new System.Drawing.Size(274, 44);
            this.tbDireccion.TabIndex = 19;
            this.tbDireccion.Text = "Av. 27 de Febrero esq. Abraham Lincoln, Unicentro Plaza, 1er Piso";
            this.tbDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbLogotipo
            // 
            this.tbLogotipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbLogotipo.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLogotipo.ForeColor = System.Drawing.Color.Black;
            this.tbLogotipo.Location = new System.Drawing.Point(17, 20);
            this.tbLogotipo.Multiline = true;
            this.tbLogotipo.Name = "tbLogotipo";
            this.tbLogotipo.ReadOnly = true;
            this.tbLogotipo.Size = new System.Drawing.Size(274, 34);
            this.tbLogotipo.TabIndex = 10;
            this.tbLogotipo.Text = "HELADERIA BON ";
            this.tbLogotipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbIncluirComprobante
            // 
            this.cbIncluirComprobante.AutoSize = true;
            this.cbIncluirComprobante.Location = new System.Drawing.Point(333, 488);
            this.cbIncluirComprobante.Name = "cbIncluirComprobante";
            this.cbIncluirComprobante.Size = new System.Drawing.Size(120, 17);
            this.cbIncluirComprobante.TabIndex = 19;
            this.cbIncluirComprobante.Text = "Incluir Comprobante";
            this.cbIncluirComprobante.UseVisualStyleBackColor = true;
            this.cbIncluirComprobante.CheckedChanged += new System.EventHandler(this.cbIncluirComprobante_CheckedChanged);
            // 
            // lbSubTotal
            // 
            this.lbSubTotal.AutoSize = true;
            this.lbSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubTotal.Location = new System.Drawing.Point(786, 487);
            this.lbSubTotal.Name = "lbSubTotal";
            this.lbSubTotal.Size = new System.Drawing.Size(86, 17);
            this.lbSubTotal.TabIndex = 22;
            this.lbSubTotal.Text = "SUBTOTAL:";
            // 
            // tbSubTotal
            // 
            this.tbSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSubTotal.Location = new System.Drawing.Point(878, 484);
            this.tbSubTotal.Multiline = true;
            this.tbSubTotal.Name = "tbSubTotal";
            this.tbSubTotal.ReadOnly = true;
            this.tbSubTotal.Size = new System.Drawing.Size(139, 20);
            this.tbSubTotal.TabIndex = 23;
            this.tbSubTotal.Text = "0.00";
            this.tbSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ClientPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1034, 628);
            this.Controls.Add(this.tbSubTotal);
            this.Controls.Add(this.lbSubTotal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlCliente);
            this.Controls.Add(this.cbIncluirComprobante);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.tbItbis);
            this.Controls.Add(this.lbItbis);
            this.Controls.Add(this.dtpFechaVenta);
            this.Controls.Add(this.dgvFacturar);
            this.Controls.Add(this.gbInfoPago);
            this.Controls.Add(this.plLogotype);
            this.Name = "ClientPayment";
            this.Text = "ClientPayment";
            this.Load += new System.EventHandler(this.ClientPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturar)).EndInit();
            this.gbInfoPago.ResumeLayout(false);
            this.gbInfoPago.PerformLayout();
            this.pnlCliente.ResumeLayout(false);
            this.pnlCliente.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Panel pnlCliente;
        private System.Windows.Forms.TextBox tbNombreCliente;
        private System.Windows.Forms.Label lbNombreCliente;
        private System.Windows.Forms.Label lbRNC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbLogotipo;
        private System.Windows.Forms.CheckBox cbIncluirComprobante;
        private System.Windows.Forms.MaskedTextBox mtbNoRNC;
        private System.Windows.Forms.Label lbSubTotal;
        private System.Windows.Forms.TextBox tbSubTotal;
    }
}