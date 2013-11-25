namespace Heladeria
{
    partial class FormCaja
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
            this.tbEfectivoAbre = new System.Windows.Forms.TextBox();
            this.tbVentasEfectivo = new System.Windows.Forms.TextBox();
            this.btCuadre = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbVentasTarjeta = new System.Windows.Forms.TextBox();
            this.btVenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbEfectivoAbre
            // 
            this.tbEfectivoAbre.Location = new System.Drawing.Point(177, 19);
            this.tbEfectivoAbre.Name = "tbEfectivoAbre";
            this.tbEfectivoAbre.ReadOnly = true;
            this.tbEfectivoAbre.Size = new System.Drawing.Size(100, 20);
            this.tbEfectivoAbre.TabIndex = 6;
            this.tbEfectivoAbre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbVentasEfectivo
            // 
            this.tbVentasEfectivo.Location = new System.Drawing.Point(410, 19);
            this.tbVentasEfectivo.Name = "tbVentasEfectivo";
            this.tbVentasEfectivo.ReadOnly = true;
            this.tbVentasEfectivo.Size = new System.Drawing.Size(100, 20);
            this.tbVentasEfectivo.TabIndex = 5;
            this.tbVentasEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btCuadre
            // 
            this.btCuadre.Location = new System.Drawing.Point(410, 114);
            this.btCuadre.Name = "btCuadre";
            this.btCuadre.Size = new System.Drawing.Size(100, 46);
            this.btCuadre.TabIndex = 4;
            this.btCuadre.Text = "Cuadrar Caja";
            this.btCuadre.UseVisualStyleBackColor = true;
            this.btCuadre.Click += new System.EventHandler(this.btCuadre_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Monto con que se abrio Caja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ventas Efectivo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ventas Tarjeta";
            // 
            // tbVentasTarjeta
            // 
            this.tbVentasTarjeta.Location = new System.Drawing.Point(410, 72);
            this.tbVentasTarjeta.Name = "tbVentasTarjeta";
            this.tbVentasTarjeta.ReadOnly = true;
            this.tbVentasTarjeta.Size = new System.Drawing.Size(100, 20);
            this.tbVentasTarjeta.TabIndex = 7;
            this.tbVentasTarjeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btVenta
            // 
            this.btVenta.Location = new System.Drawing.Point(62, 70);
            this.btVenta.Name = "btVenta";
            this.btVenta.Size = new System.Drawing.Size(177, 90);
            this.btVenta.TabIndex = 8;
            this.btVenta.Text = "Nueva Venta";
            this.btVenta.UseVisualStyleBackColor = true;
            // 
            // FormCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 182);
            this.Controls.Add(this.btVenta);
            this.Controls.Add(this.tbVentasTarjeta);
            this.Controls.Add(this.tbEfectivoAbre);
            this.Controls.Add(this.tbVentasEfectivo);
            this.Controls.Add(this.btCuadre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCaja";
            this.Text = "FormCaja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btCuadre;
        private System.Windows.Forms.TextBox tbVentasEfectivo;
        private System.Windows.Forms.TextBox tbEfectivoAbre;
        private System.Windows.Forms.TextBox tbVentasTarjeta;
        private System.Windows.Forms.Button btVenta;
    }
}