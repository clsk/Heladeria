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
            this.SuspendLayout();
            // 
            // btnCaja
            // 
            this.btnCaja.Location = new System.Drawing.Point(65, 69);
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.Size = new System.Drawing.Size(108, 96);
            this.btnCaja.TabIndex = 0;
            this.btnCaja.Text = "Caja";
            this.btnCaja.UseVisualStyleBackColor = true;
            // 
            // btLogout
            // 
            this.btLogout.Location = new System.Drawing.Point(238, 69);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(108, 96);
            this.btLogout.TabIndex = 1;
            this.btLogout.Text = "Salir";
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 275);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.btnCaja);
            this.Name = "FormMain";
            this.Text = "Bienvenido!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCaja;
        private System.Windows.Forms.Button btLogout;
    }
}