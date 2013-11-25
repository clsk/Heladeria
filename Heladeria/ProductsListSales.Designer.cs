namespace Heladeria
{
    partial class ProductsListSales
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
            this.dgvListaProductos = new System.Windows.Forms.DataGridView();
            this.tbNoArt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitarioArt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaProductos
            // 
            this.dgvListaProductos.AllowUserToAddRows = false;
            this.dgvListaProductos.AllowUserToDeleteRows = false;
            this.dgvListaProductos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tbNoArt,
            this.CodigoArticulo,
            this.DescripcionArticulo,
            this.PrecioUnitarioArt});
            this.dgvListaProductos.Location = new System.Drawing.Point(5, 3);
            this.dgvListaProductos.MultiSelect = false;
            this.dgvListaProductos.Name = "dgvListaProductos";
            this.dgvListaProductos.ReadOnly = true;
            this.dgvListaProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaProductos.Size = new System.Drawing.Size(663, 305);
            this.dgvListaProductos.TabIndex = 1;
            // 
            // tbNoArt
            // 
            this.tbNoArt.Frozen = true;
            this.tbNoArt.HeaderText = "No. de Art.";
            this.tbNoArt.Name = "tbNoArt";
            this.tbNoArt.ReadOnly = true;
            this.tbNoArt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            this.DescripcionArticulo.HeaderText = "Descripcion";
            this.DescripcionArticulo.Name = "DescripcionArticulo";
            this.DescripcionArticulo.ReadOnly = true;
            this.DescripcionArticulo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DescripcionArticulo.Width = 320;
            // 
            // PrecioUnitarioArt
            // 
            this.PrecioUnitarioArt.Frozen = true;
            this.PrecioUnitarioArt.HeaderText = "Precio Unitario";
            this.PrecioUnitarioArt.Name = "PrecioUnitarioArt";
            this.PrecioUnitarioArt.ReadOnly = true;
            this.PrecioUnitarioArt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ProductsListSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 313);
            this.Controls.Add(this.dgvListaProductos);
            this.Name = "ProductsListSales";
            this.Text = "ProductsListSales";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbNoArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitarioArt;
    }
}