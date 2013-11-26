namespace Heladeria
{
    partial class ClientOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientOrder));
            this.plLogotype = new System.Windows.Forms.Panel();
            this.dgvPedidoProductos = new System.Windows.Forms.DataGridView();
            this.NumeroArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadArticulos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitarioArt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreciosTotalArt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.tbMontoTotal = new System.Windows.Forms.TextBox();
            this.tbItbis = new System.Windows.Forms.TextBox();
            this.tbDescuento = new System.Windows.Forms.TextBox();
            this.tbSubTotal = new System.Windows.Forms.TextBox();
            this.lbMontoTotal = new System.Windows.Forms.Label();
            this.lbItbis = new System.Windows.Forms.Label();
            this.lbDescuento = new System.Windows.Forms.Label();
            this.lbSubTotal = new System.Windows.Forms.Label();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // plLogotype
            // 
            this.plLogotype.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plLogotype.BackgroundImage")));
            this.plLogotype.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plLogotype.Location = new System.Drawing.Point(12, 12);
            this.plLogotype.Name = "plLogotype";
            this.plLogotype.Size = new System.Drawing.Size(257, 119);
            this.plLogotype.TabIndex = 0;
            // 
            // dgvPedidoProductos
            // 
            this.dgvPedidoProductos.AllowUserToAddRows = false;
            this.dgvPedidoProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvPedidoProductos.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvPedidoProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPedidoProductos.ColumnHeadersHeight = 28;
            this.dgvPedidoProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPedidoProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroArticulo,
            this.CodigoArticulo,
            this.DescripcionArticulo,
            this.CantidadArticulos,
            this.PrecioUnitarioArt,
            this.PreciosTotalArt});
            this.dgvPedidoProductos.Location = new System.Drawing.Point(11, 137);
            this.dgvPedidoProductos.Name = "dgvPedidoProductos";
            this.dgvPedidoProductos.ReadOnly = true;
            this.dgvPedidoProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPedidoProductos.RowHeadersWidth = 45;
            this.dgvPedidoProductos.RowTemplate.Height = 30;
            this.dgvPedidoProductos.Size = new System.Drawing.Size(903, 244);
            this.dgvPedidoProductos.TabIndex = 2;
            // 
            // NumeroArticulo
            // 
            this.NumeroArticulo.Frozen = true;
            this.NumeroArticulo.HeaderText = "No. Art.";
            this.NumeroArticulo.Name = "NumeroArticulo";
            this.NumeroArticulo.ReadOnly = true;
            this.NumeroArticulo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NumeroArticulo.Width = 80;
            // 
            // CodigoArticulo
            // 
            this.CodigoArticulo.Frozen = true;
            this.CodigoArticulo.HeaderText = "Cod. Art.";
            this.CodigoArticulo.Name = "CodigoArticulo";
            this.CodigoArticulo.ReadOnly = true;
            this.CodigoArticulo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // DescripcionArticulo
            // 
            this.DescripcionArticulo.Frozen = true;
            this.DescripcionArticulo.HeaderText = "Descripción";
            this.DescripcionArticulo.Name = "DescripcionArticulo";
            this.DescripcionArticulo.ReadOnly = true;
            this.DescripcionArticulo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DescripcionArticulo.Width = 320;
            // 
            // CantidadArticulos
            // 
            this.CantidadArticulos.Frozen = true;
            this.CantidadArticulos.HeaderText = "Cantidad";
            this.CantidadArticulos.Name = "CantidadArticulos";
            this.CantidadArticulos.ReadOnly = true;
            this.CantidadArticulos.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // PrecioUnitarioArt
            // 
            this.PrecioUnitarioArt.Frozen = true;
            this.PrecioUnitarioArt.HeaderText = "Precio Unitario";
            this.PrecioUnitarioArt.Name = "PrecioUnitarioArt";
            this.PrecioUnitarioArt.ReadOnly = true;
            this.PrecioUnitarioArt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PrecioUnitarioArt.Width = 150;
            // 
            // PreciosTotalArt
            // 
            this.PreciosTotalArt.Frozen = true;
            this.PreciosTotalArt.HeaderText = "Total";
            this.PreciosTotalArt.Name = "PreciosTotalArt";
            this.PreciosTotalArt.ReadOnly = true;
            this.PreciosTotalArt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PreciosTotalArt.Width = 150;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnActualizar.Location = new System.Drawing.Point(11, 466);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(106, 32);
            this.btnActualizar.TabIndex = 27;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(11, 428);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(106, 32);
            this.btnCerrar.TabIndex = 26;
            this.btnCerrar.Text = "Salir";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Red;
            this.btnReset.Location = new System.Drawing.Point(11, 390);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(106, 32);
            this.btnReset.TabIndex = 25;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnProcesar
            // 
            this.btnProcesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesar.ForeColor = System.Drawing.Color.Green;
            this.btnProcesar.Location = new System.Drawing.Point(808, 500);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(106, 32);
            this.btnProcesar.TabIndex = 24;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // tbMontoTotal
            // 
            this.tbMontoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMontoTotal.Location = new System.Drawing.Point(774, 474);
            this.tbMontoTotal.Multiline = true;
            this.tbMontoTotal.Name = "tbMontoTotal";
            this.tbMontoTotal.ReadOnly = true;
            this.tbMontoTotal.Size = new System.Drawing.Size(139, 20);
            this.tbMontoTotal.TabIndex = 23;
            this.tbMontoTotal.Text = "RD$ 0.00";
            this.tbMontoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbItbis
            // 
            this.tbItbis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbItbis.Location = new System.Drawing.Point(774, 446);
            this.tbItbis.Multiline = true;
            this.tbItbis.Name = "tbItbis";
            this.tbItbis.ReadOnly = true;
            this.tbItbis.Size = new System.Drawing.Size(139, 20);
            this.tbItbis.TabIndex = 22;
            this.tbItbis.Text = "RD$ 0.00";
            this.tbItbis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbDescuento
            // 
            this.tbDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescuento.Location = new System.Drawing.Point(774, 416);
            this.tbDescuento.Multiline = true;
            this.tbDescuento.Name = "tbDescuento";
            this.tbDescuento.ReadOnly = true;
            this.tbDescuento.Size = new System.Drawing.Size(139, 20);
            this.tbDescuento.TabIndex = 21;
            this.tbDescuento.Text = "RD$ 0.00";
            this.tbDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbSubTotal
            // 
            this.tbSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSubTotal.Location = new System.Drawing.Point(774, 387);
            this.tbSubTotal.Multiline = true;
            this.tbSubTotal.Name = "tbSubTotal";
            this.tbSubTotal.ReadOnly = true;
            this.tbSubTotal.Size = new System.Drawing.Size(139, 20);
            this.tbSubTotal.TabIndex = 20;
            this.tbSubTotal.Text = "RD$ 0.00";
            this.tbSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbMontoTotal
            // 
            this.lbMontoTotal.AutoSize = true;
            this.lbMontoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMontoTotal.Location = new System.Drawing.Point(724, 477);
            this.lbMontoTotal.Name = "lbMontoTotal";
            this.lbMontoTotal.Size = new System.Drawing.Size(44, 17);
            this.lbMontoTotal.TabIndex = 19;
            this.lbMontoTotal.Text = "Total:";
            // 
            // lbItbis
            // 
            this.lbItbis.AutoSize = true;
            this.lbItbis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbItbis.Location = new System.Drawing.Point(723, 449);
            this.lbItbis.Name = "lbItbis";
            this.lbItbis.Size = new System.Drawing.Size(45, 17);
            this.lbItbis.TabIndex = 18;
            this.lbItbis.Text = "ITBIS:";
            // 
            // lbDescuento
            // 
            this.lbDescuento.AutoSize = true;
            this.lbDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescuento.Location = new System.Drawing.Point(688, 419);
            this.lbDescuento.Name = "lbDescuento";
            this.lbDescuento.Size = new System.Drawing.Size(80, 17);
            this.lbDescuento.TabIndex = 17;
            this.lbDescuento.Text = "Descuento:";
            // 
            // lbSubTotal
            // 
            this.lbSubTotal.AutoSize = true;
            this.lbSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubTotal.Location = new System.Drawing.Point(694, 390);
            this.lbSubTotal.Name = "lbSubTotal";
            this.lbSubTotal.Size = new System.Drawing.Size(74, 17);
            this.lbSubTotal.TabIndex = 16;
            this.lbSubTotal.Text = "Sub-Total:";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(788, 90);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(126, 30);
            this.btnAgregarProducto.TabIndex = 15;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // ClientOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(926, 580);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.tbMontoTotal);
            this.Controls.Add(this.tbItbis);
            this.Controls.Add(this.tbDescuento);
            this.Controls.Add(this.tbSubTotal);
            this.Controls.Add(this.lbMontoTotal);
            this.Controls.Add(this.lbItbis);
            this.Controls.Add(this.lbDescuento);
            this.Controls.Add(this.lbSubTotal);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.dgvPedidoProductos);
            this.Controls.Add(this.plLogotype);
            this.Name = "ClientOrder";
            this.Text = "Solicitud De Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel plLogotype;
        private System.Windows.Forms.DataGridView dgvPedidoProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadArticulos;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitarioArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreciosTotalArt;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.TextBox tbMontoTotal;
        private System.Windows.Forms.TextBox tbItbis;
        private System.Windows.Forms.TextBox tbDescuento;
        private System.Windows.Forms.TextBox tbSubTotal;
        private System.Windows.Forms.Label lbMontoTotal;
        private System.Windows.Forms.Label lbItbis;
        private System.Windows.Forms.Label lbDescuento;
        private System.Windows.Forms.Label lbSubTotal;
        private System.Windows.Forms.Button btnAgregarProducto;
    }
}