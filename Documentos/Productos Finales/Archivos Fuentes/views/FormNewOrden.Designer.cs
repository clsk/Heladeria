namespace Heladeria
{
    partial class FormNewOrden
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
            this.btCancelar = new System.Windows.Forms.Button();
            this.btOrdenar = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(12, 353);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(111, 35);
            this.btCancelar.TabIndex = 2;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btOrdenar
            // 
            this.btOrdenar.Location = new System.Drawing.Point(769, 353);
            this.btOrdenar.Name = "btOrdenar";
            this.btOrdenar.Size = new System.Drawing.Size(111, 35);
            this.btOrdenar.TabIndex = 1;
            this.btOrdenar.Text = "Ordenar";
            this.btOrdenar.UseVisualStyleBackColor = true;
            this.btOrdenar.Click += new System.EventHandler(this.btOrdenar_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(12, 12);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(868, 325);
            this.dgvProductos.TabIndex = 0;
            this.dgvProductos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellEndEdit);
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(375, 363);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(100, 20);
            this.tbTotal.TabIndex = 3;
            this.tbTotal.Text = "0.00";
            this.tbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total";
            // 
            // FormNewOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 398);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btOrdenar);
            this.Controls.Add(this.dgvProductos);
            this.Name = "FormNewOrden";
            this.Text = "FormNewOrden";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btOrdenar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label1;
    }
}