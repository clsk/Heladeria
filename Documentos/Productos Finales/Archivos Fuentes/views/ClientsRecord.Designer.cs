namespace Heladeria
{
    partial class ClientsRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsRecord));
            this.gbInformacionesCliente = new System.Windows.Forms.GroupBox();
            this.mtbTelefono = new System.Windows.Forms.MaskedTextBox();
            this.tbProvincia = new System.Windows.Forms.TextBox();
            this.lbProvincia = new System.Windows.Forms.Label();
            this.tbRNC = new System.Windows.Forms.TextBox();
            this.lbRNC = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lbNombreCliente = new System.Windows.Forms.Label();
            this.lbNotas = new System.Windows.Forms.Label();
            this.tbNotas = new System.Windows.Forms.TextBox();
            this.tbNombreCliente = new System.Windows.Forms.TextBox();
            this.tbApellidoCliente = new System.Windows.Forms.TextBox();
            this.tbNumeroCliente = new System.Windows.Forms.TextBox();
            this.lbNumero = new System.Windows.Forms.Label();
            this.tbCalleCliente = new System.Windows.Forms.TextBox();
            this.lbCalle = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
            this.tbSector = new System.Windows.Forms.TextBox();
            this.lbSector = new System.Windows.Forms.Label();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.lbCorreoElectronico = new System.Windows.Forms.Label();
            this.tbCorreoElecCliente = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.llbCancelar = new System.Windows.Forms.LinkLabel();
            this.gbInformacionesCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInformacionesCliente
            // 
            this.gbInformacionesCliente.Controls.Add(this.llbCancelar);
            this.gbInformacionesCliente.Controls.Add(this.btnContinuar);
            this.gbInformacionesCliente.Controls.Add(this.mtbTelefono);
            this.gbInformacionesCliente.Controls.Add(this.tbProvincia);
            this.gbInformacionesCliente.Controls.Add(this.lbProvincia);
            this.gbInformacionesCliente.Controls.Add(this.tbRNC);
            this.gbInformacionesCliente.Controls.Add(this.lbRNC);
            this.gbInformacionesCliente.Controls.Add(this.btnBuscar);
            this.gbInformacionesCliente.Controls.Add(this.btnEditar);
            this.gbInformacionesCliente.Controls.Add(this.btnSalvar);
            this.gbInformacionesCliente.Controls.Add(this.lbNombreCliente);
            this.gbInformacionesCliente.Controls.Add(this.lbNotas);
            this.gbInformacionesCliente.Controls.Add(this.tbNotas);
            this.gbInformacionesCliente.Controls.Add(this.tbNombreCliente);
            this.gbInformacionesCliente.Controls.Add(this.tbApellidoCliente);
            this.gbInformacionesCliente.Controls.Add(this.tbNumeroCliente);
            this.gbInformacionesCliente.Controls.Add(this.lbNumero);
            this.gbInformacionesCliente.Controls.Add(this.tbCalleCliente);
            this.gbInformacionesCliente.Controls.Add(this.lbCalle);
            this.gbInformacionesCliente.Controls.Add(this.lbApellido);
            this.gbInformacionesCliente.Controls.Add(this.tbSector);
            this.gbInformacionesCliente.Controls.Add(this.lbSector);
            this.gbInformacionesCliente.Controls.Add(this.lbTelefono);
            this.gbInformacionesCliente.Controls.Add(this.lbCorreoElectronico);
            this.gbInformacionesCliente.Controls.Add(this.tbCorreoElecCliente);
            this.gbInformacionesCliente.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacionesCliente.Location = new System.Drawing.Point(12, 175);
            this.gbInformacionesCliente.Name = "gbInformacionesCliente";
            this.gbInformacionesCliente.Size = new System.Drawing.Size(575, 340);
            this.gbInformacionesCliente.TabIndex = 26;
            this.gbInformacionesCliente.TabStop = false;
            this.gbInformacionesCliente.Text = "Informaciones Del Cliente";
            // 
            // mtbTelefono
            // 
            this.mtbTelefono.Location = new System.Drawing.Point(282, 79);
            this.mtbTelefono.Mask = "909-000-0000";
            this.mtbTelefono.Name = "mtbTelefono";
            this.mtbTelefono.Size = new System.Drawing.Size(228, 22);
            this.mtbTelefono.TabIndex = 32;
            this.mtbTelefono.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbTelefono_MaskInputRejected);
            // 
            // tbProvincia
            // 
            this.tbProvincia.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProvincia.Location = new System.Drawing.Point(9, 283);
            this.tbProvincia.Name = "tbProvincia";
            this.tbProvincia.ReadOnly = true;
            this.tbProvincia.Size = new System.Drawing.Size(228, 22);
            this.tbProvincia.TabIndex = 31;
            this.tbProvincia.Text = "Santo Domingo";
            // 
            // lbProvincia
            // 
            this.lbProvincia.AutoSize = true;
            this.lbProvincia.Location = new System.Drawing.Point(6, 266);
            this.lbProvincia.Name = "lbProvincia";
            this.lbProvincia.Size = new System.Drawing.Size(69, 14);
            this.lbProvincia.TabIndex = 30;
            this.lbProvincia.Text = "Provincia:";
            // 
            // tbRNC
            // 
            this.tbRNC.Location = new System.Drawing.Point(282, 130);
            this.tbRNC.Name = "tbRNC";
            this.tbRNC.Size = new System.Drawing.Size(228, 22);
            this.tbRNC.TabIndex = 26;
            // 
            // lbRNC
            // 
            this.lbRNC.AutoSize = true;
            this.lbRNC.Location = new System.Drawing.Point(279, 114);
            this.lbRNC.Name = "lbRNC";
            this.lbRNC.Size = new System.Drawing.Size(68, 14);
            this.lbRNC.TabIndex = 25;
            this.lbRNC.Text = "RNC No.:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(376, 299);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(88, 24);
            this.btnBuscar.TabIndex = 24;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(470, 299);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(88, 24);
            this.btnEditar.TabIndex = 23;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(282, 299);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(88, 24);
            this.btnSalvar.TabIndex = 22;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lbNombreCliente
            // 
            this.lbNombreCliente.AutoSize = true;
            this.lbNombreCliente.Location = new System.Drawing.Point(6, 16);
            this.lbNombreCliente.Name = "lbNombreCliente";
            this.lbNombreCliente.Size = new System.Drawing.Size(62, 14);
            this.lbNombreCliente.TabIndex = 1;
            this.lbNombreCliente.Text = "Nombre:";
            // 
            // lbNotas
            // 
            this.lbNotas.AutoSize = true;
            this.lbNotas.Location = new System.Drawing.Point(279, 159);
            this.lbNotas.Name = "lbNotas";
            this.lbNotas.Size = new System.Drawing.Size(47, 14);
            this.lbNotas.TabIndex = 20;
            this.lbNotas.Text = "Notas:";
            // 
            // tbNotas
            // 
            this.tbNotas.Location = new System.Drawing.Point(282, 179);
            this.tbNotas.Multiline = true;
            this.tbNotas.Name = "tbNotas";
            this.tbNotas.Size = new System.Drawing.Size(228, 60);
            this.tbNotas.TabIndex = 21;
            // 
            // tbNombreCliente
            // 
            this.tbNombreCliente.Location = new System.Drawing.Point(9, 32);
            this.tbNombreCliente.Name = "tbNombreCliente";
            this.tbNombreCliente.Size = new System.Drawing.Size(228, 22);
            this.tbNombreCliente.TabIndex = 7;
            // 
            // tbApellidoCliente
            // 
            this.tbApellidoCliente.Location = new System.Drawing.Point(9, 79);
            this.tbApellidoCliente.Name = "tbApellidoCliente";
            this.tbApellidoCliente.Size = new System.Drawing.Size(228, 22);
            this.tbApellidoCliente.TabIndex = 8;
            // 
            // tbNumeroCliente
            // 
            this.tbNumeroCliente.Location = new System.Drawing.Point(9, 231);
            this.tbNumeroCliente.Name = "tbNumeroCliente";
            this.tbNumeroCliente.Size = new System.Drawing.Size(228, 22);
            this.tbNumeroCliente.TabIndex = 12;
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Location = new System.Drawing.Point(6, 214);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(62, 14);
            this.lbNumero.TabIndex = 6;
            this.lbNumero.Text = "Número:";
            // 
            // tbCalleCliente
            // 
            this.tbCalleCliente.Location = new System.Drawing.Point(9, 179);
            this.tbCalleCliente.Name = "tbCalleCliente";
            this.tbCalleCliente.Size = new System.Drawing.Size(228, 22);
            this.tbCalleCliente.TabIndex = 11;
            // 
            // lbCalle
            // 
            this.lbCalle.AutoSize = true;
            this.lbCalle.Location = new System.Drawing.Point(6, 159);
            this.lbCalle.Name = "lbCalle";
            this.lbCalle.Size = new System.Drawing.Size(39, 14);
            this.lbCalle.TabIndex = 5;
            this.lbCalle.Text = "Calle";
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Location = new System.Drawing.Point(6, 62);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(64, 14);
            this.lbApellido.TabIndex = 2;
            this.lbApellido.Text = "Apellido:";
            // 
            // tbSector
            // 
            this.tbSector.Location = new System.Drawing.Point(9, 130);
            this.tbSector.Name = "tbSector";
            this.tbSector.Size = new System.Drawing.Size(228, 22);
            this.tbSector.TabIndex = 10;
            // 
            // lbSector
            // 
            this.lbSector.AutoSize = true;
            this.lbSector.Location = new System.Drawing.Point(6, 114);
            this.lbSector.Name = "lbSector";
            this.lbSector.Size = new System.Drawing.Size(50, 14);
            this.lbSector.TabIndex = 4;
            this.lbSector.Text = "Sector:";
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Location = new System.Drawing.Point(279, 62);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(68, 14);
            this.lbTelefono.TabIndex = 3;
            this.lbTelefono.Text = "Teléfono:";
            // 
            // lbCorreoElectronico
            // 
            this.lbCorreoElectronico.AutoSize = true;
            this.lbCorreoElectronico.Location = new System.Drawing.Point(279, 16);
            this.lbCorreoElectronico.Name = "lbCorreoElectronico";
            this.lbCorreoElectronico.Size = new System.Drawing.Size(126, 14);
            this.lbCorreoElectronico.TabIndex = 13;
            this.lbCorreoElectronico.Text = "Correo Electrónico";
            // 
            // tbCorreoElecCliente
            // 
            this.tbCorreoElecCliente.Location = new System.Drawing.Point(282, 33);
            this.tbCorreoElecCliente.Name = "tbCorreoElecCliente";
            this.tbCorreoElecCliente.Size = new System.Drawing.Size(228, 22);
            this.tbCorreoElecCliente.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 142);
            this.panel1.TabIndex = 25;
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Font = new System.Drawing.Font("Baskerville Old Face", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCliente.ForeColor = System.Drawing.Color.Red;
            this.btnNuevoCliente.Location = new System.Drawing.Point(482, 12);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(105, 56);
            this.btnNuevoCliente.TabIndex = 29;
            this.btnNuevoCliente.Text = "Nuevo Cliente";
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(361, 258);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(124, 35);
            this.btnContinuar.TabIndex = 33;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // llbCancelar
            // 
            this.llbCancelar.AutoSize = true;
            this.llbCancelar.Location = new System.Drawing.Point(6, 323);
            this.llbCancelar.Name = "llbCancelar";
            this.llbCancelar.Size = new System.Drawing.Size(62, 14);
            this.llbCancelar.TabIndex = 34;
            this.llbCancelar.TabStop = true;
            this.llbCancelar.Text = "Cancelar";
            this.llbCancelar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbCancelar_LinkClicked);
            // 
            // ClientsRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(607, 526);
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.gbInformacionesCliente);
            this.Controls.Add(this.panel1);
            this.Name = "ClientsRecord";
            this.Text = "ClientsRecord";
            this.gbInformacionesCliente.ResumeLayout(false);
            this.gbInformacionesCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInformacionesCliente;
        private System.Windows.Forms.TextBox tbRNC;
        private System.Windows.Forms.Label lbRNC;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lbNombreCliente;
        private System.Windows.Forms.Label lbNotas;
        private System.Windows.Forms.TextBox tbNotas;
        private System.Windows.Forms.TextBox tbNombreCliente;
        private System.Windows.Forms.TextBox tbApellidoCliente;
        private System.Windows.Forms.TextBox tbNumeroCliente;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.TextBox tbCalleCliente;
        private System.Windows.Forms.Label lbCalle;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.TextBox tbSector;
        private System.Windows.Forms.Label lbSector;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.Label lbCorreoElectronico;
        private System.Windows.Forms.TextBox tbCorreoElecCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbProvincia;
        private System.Windows.Forms.Label lbProvincia;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.MaskedTextBox mtbTelefono;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.LinkLabel llbCancelar;
    }
}