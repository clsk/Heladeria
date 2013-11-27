namespace Heladeria
{
    partial class DialogSuplidores
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
            this.cbSuplidores = new System.Windows.Forms.ComboBox();
            this.btSeleccionar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbSuplidores
            // 
            this.cbSuplidores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSuplidores.FormattingEnabled = true;
            this.cbSuplidores.Location = new System.Drawing.Point(27, 12);
            this.cbSuplidores.Name = "cbSuplidores";
            this.cbSuplidores.Size = new System.Drawing.Size(167, 21);
            this.cbSuplidores.TabIndex = 0;
            // 
            // btSeleccionar
            // 
            this.btSeleccionar.Location = new System.Drawing.Point(119, 51);
            this.btSeleccionar.Name = "btSeleccionar";
            this.btSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btSeleccionar.TabIndex = 1;
            this.btSeleccionar.Text = "Seleccionar";
            this.btSeleccionar.UseVisualStyleBackColor = true;
            this.btSeleccionar.Click += new System.EventHandler(this.btSeleccionar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Location = new System.Drawing.Point(27, 51);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 2;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // DialogSuplidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancelar;
            this.ClientSize = new System.Drawing.Size(218, 91);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSeleccionar);
            this.Controls.Add(this.cbSuplidores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DialogSuplidores";
            this.Text = "Seleccione Suplidor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSuplidores;
        private System.Windows.Forms.Button btSeleccionar;
        private System.Windows.Forms.Button btCancelar;
    }
}