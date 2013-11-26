namespace Heladeria
{
    partial class FormViewOrders
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
            this.btNuevaOrden = new System.Windows.Forms.Button();
            this.btCancelarOrden = new System.Windows.Forms.Button();
            this.dgvOrdenes = new System.Windows.Forms.DataGridView();
            this.btVerOrden = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).BeginInit();
            this.SuspendLayout();
            // 
            // btNuevaOrden
            // 
            this.btNuevaOrden.Location = new System.Drawing.Point(643, 12);
            this.btNuevaOrden.Name = "btNuevaOrden";
            this.btNuevaOrden.Size = new System.Drawing.Size(94, 47);
            this.btNuevaOrden.TabIndex = 3;
            this.btNuevaOrden.Text = "Nueva Orden";
            this.btNuevaOrden.UseVisualStyleBackColor = true;
            this.btNuevaOrden.Click += new System.EventHandler(this.btNuevaOrden_Click);
            // 
            // btCancelarOrden
            // 
            this.btCancelarOrden.Location = new System.Drawing.Point(643, 146);
            this.btCancelarOrden.Name = "btCancelarOrden";
            this.btCancelarOrden.Size = new System.Drawing.Size(94, 47);
            this.btCancelarOrden.TabIndex = 2;
            this.btCancelarOrden.Text = "Cancelar Orden";
            this.btCancelarOrden.UseVisualStyleBackColor = true;
            this.btCancelarOrden.Click += new System.EventHandler(this.btCancelarOrden_Click);
            // 
            // dgvOrdenes
            // 
            this.dgvOrdenes.AllowUserToAddRows = false;
            this.dgvOrdenes.AllowUserToDeleteRows = false;
            this.dgvOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenes.Location = new System.Drawing.Point(12, 12);
            this.dgvOrdenes.MultiSelect = false;
            this.dgvOrdenes.Name = "dgvOrdenes";
            this.dgvOrdenes.Size = new System.Drawing.Size(625, 181);
            this.dgvOrdenes.TabIndex = 0;
            // 
            // btVerOrden
            // 
            this.btVerOrden.Location = new System.Drawing.Point(643, 79);
            this.btVerOrden.Name = "btVerOrden";
            this.btVerOrden.Size = new System.Drawing.Size(94, 47);
            this.btVerOrden.TabIndex = 4;
            this.btVerOrden.Text = "Ver Orden";
            this.btVerOrden.UseVisualStyleBackColor = true;
            this.btVerOrden.Click += new System.EventHandler(this.btVerOrden_Click);
            // 
            // FormViewOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 206);
            this.Controls.Add(this.btVerOrden);
            this.Controls.Add(this.btNuevaOrden);
            this.Controls.Add(this.btCancelarOrden);
            this.Controls.Add(this.dgvOrdenes);
            this.Name = "FormViewOrders";
            this.Text = "FormViewOrders";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrdenes;
        private System.Windows.Forms.Button btCancelarOrden;
        private System.Windows.Forms.Button btNuevaOrden;
        private System.Windows.Forms.Button btVerOrden;
    }
}