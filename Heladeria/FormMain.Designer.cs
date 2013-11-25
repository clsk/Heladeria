namespace Heladeria
{
    partial class FormMain
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
            this.btnCaja = new System.Windows.Forms.Button();
            this.btLogout = new System.Windows.Forms.Button();
            this.btOrdenes = new System.Windows.Forms.Button();
            this.btInventario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCaja
            // 
            this.btnCaja.Location = new System.Drawing.Point(78, 45);
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.Size = new System.Drawing.Size(108, 96);
            this.btnCaja.TabIndex = 0;
            this.btnCaja.Text = "Crear Caja";
            this.btnCaja.UseVisualStyleBackColor = true;
            this.btnCaja.Click += new System.EventHandler(this.btnCaja_Click);
            // 
            // btLogout
            // 
            this.btLogout.Location = new System.Drawing.Point(284, 45);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(108, 96);
            this.btLogout.TabIndex = 1;
            this.btLogout.Text = "Salir";
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // btOrdenes
            // 
            this.btOrdenes.Location = new System.Drawing.Point(284, 167);
            this.btOrdenes.Name = "btOrdenes";
            this.btOrdenes.Size = new System.Drawing.Size(108, 96);
            this.btOrdenes.TabIndex = 2;
            this.btOrdenes.Text = "Ordenes";
            this.btOrdenes.UseVisualStyleBackColor = true;
            this.btOrdenes.Click += new System.EventHandler(this.btOrdenes_Click);
            // 
            // btInventario
            // 
            this.btInventario.Location = new System.Drawing.Point(78, 167);
            this.btInventario.Name = "btInventario";
            this.btInventario.Size = new System.Drawing.Size(108, 96);
            this.btInventario.TabIndex = 3;
            this.btInventario.Text = "Inventario";
            this.btInventario.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 275);
            this.Controls.Add(this.btInventario);
            this.Controls.Add(this.btOrdenes);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.btnCaja);
            this.Name = "FormMain";
            this.Text = "Bienvenido!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCaja;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button btOrdenes;
        private System.Windows.Forms.Button btInventario;
    }
}