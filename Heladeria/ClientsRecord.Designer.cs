namespace Views
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
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.gbInformacionesCliente = new System.Windows.Forms.GroupBox();
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
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lbCorreoElectronico = new System.Windows.Forms.Label();
            this.lbFechaNacimiento = new System.Windows.Forms.Label();
            this.tbCorreoElecCliente = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbInformacionesCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAyuda
            // 
            this.btnAyuda.Location = new System.Drawing.Point(536, 12);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(51, 47);
            this.btnAyuda.TabIndex = 28;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(471, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(51, 47);
            this.btnHome.TabIndex = 27;
            this.btnHome.Text = "Inicio";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // gbInformacionesCliente
            // 
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
            this.gbInformacionesCliente.Controls.Add(this.tbTelefono);
            this.gbInformacionesCliente.Controls.Add(this.lbTelefono);
            this.gbInformacionesCliente.Controls.Add(this.dtpFechaNacimiento);
            this.gbInformacionesCliente.Controls.Add(this.lbCorreoElectronico);
            this.gbInformacionesCliente.Controls.Add(this.lbFechaNacimiento);
            this.gbInformacionesCliente.Controls.Add(this.tbCorreoElecCliente);
            this.gbInformacionesCliente.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacionesCliente.Location = new System.Drawing.Point(12, 175);
            this.gbInformacionesCliente.Name = "gbInformacionesCliente";
            this.gbInformacionesCliente.Size = new System.Drawing.Size(575, 340);
            this.gbInformacionesCliente.TabIndex = 26;
            this.gbInformacionesCliente.TabStop = false;
            this.gbInformacionesCliente.Text = "Informaciones Del Cliente";
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
            this.tbNumeroCliente.Location = new System.Drawing.Point(9, 287);
            this.tbNumeroCliente.Name = "tbNumeroCliente";
            this.tbNumeroCliente.Size = new System.Drawing.Size(228, 22);
            this.tbNumeroCliente.TabIndex = 12;
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Location = new System.Drawing.Point(6, 270);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(62, 14);
            this.lbNumero.TabIndex = 6;
            this.lbNumero.Text = "Número:";
            // 
            // tbCalleCliente
            // 
            this.tbCalleCliente.Location = new System.Drawing.Point(9, 233);
            this.tbCalleCliente.Name = "tbCalleCliente";
            this.tbCalleCliente.Size = new System.Drawing.Size(228, 22);
            this.tbCalleCliente.TabIndex = 11;
            // 
            // lbCalle
            // 
            this.lbCalle.AutoSize = true;
            this.lbCalle.Location = new System.Drawing.Point(6, 216);
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
            this.tbSector.Location = new System.Drawing.Point(9, 179);
            this.tbSector.Name = "tbSector";
            this.tbSector.Size = new System.Drawing.Size(228, 22);
            this.tbSector.TabIndex = 10;
            // 
            // lbSector
            // 
            this.lbSector.AutoSize = true;
            this.lbSector.Location = new System.Drawing.Point(6, 162);
            this.lbSector.Name = "lbSector";
            this.lbSector.Size = new System.Drawing.Size(50, 14);
            this.lbSector.TabIndex = 4;
            this.lbSector.Text = "Sector:";
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(282, 79);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(228, 22);
            this.tbTelefono.TabIndex = 9;
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
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(9, 127);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(228, 22);
            this.dtpFechaNacimiento.TabIndex = 16;
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
            // lbFechaNacimiento
            // 
            this.lbFechaNacimiento.AutoSize = true;
            this.lbFechaNacimiento.Location = new System.Drawing.Point(6, 110);
            this.lbFechaNacimiento.Name = "lbFechaNacimiento";
            this.lbFechaNacimiento.Size = new System.Drawing.Size(136, 14);
            this.lbFechaNacimiento.TabIndex = 15;
            this.lbFechaNacimiento.Text = "Fecha de Nacimiento";
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
            // ClientsRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(607, 526);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.gbInformacionesCliente);
            this.Controls.Add(this.panel1);
            this.Name = "ClientsRecord";
            this.Text = "ClientsRecord";
            this.gbInformacionesCliente.ResumeLayout(false);
            this.gbInformacionesCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnHome;
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
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lbCorreoElectronico;
        private System.Windows.Forms.Label lbFechaNacimiento;
        private System.Windows.Forms.TextBox tbCorreoElecCliente;
        private System.Windows.Forms.Panel panel1;
    }
}