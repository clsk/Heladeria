using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;

namespace Heladeria
{
    public partial class ClientsRecord : BaseForm
    {
        private int _ThisClientID;
        
        public ClientsRecord(Form previousForm) : base(previousForm)
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!tbNombreCliente.ReadOnly)
            {
                ClientesHelper _OneClient = new ClientesHelper();
                Cliente _cliente = new Cliente();
                _cliente = _OneClient.Get(_ThisClientID);

                if (_cliente != null)
                {
                    _OneClient.Attach(_cliente);

                    _cliente.nombre = tbNombreCliente.Text.ToString(); ;
                    _cliente.apellido = tbApellidoCliente.Text.ToString(); ;
                    _cliente.correo = tbCorreoElecCliente.Text.ToString(); ;
                    _cliente.sector = tbSector.Text.ToString(); ;
                    _cliente.calle = tbCalleCliente.Text.ToString();
                    _cliente.no_casa = tbNumeroCliente.Text.ToString();
                    _cliente.RNC = tbRNC.Text.ToString();

                    _OneClient.SaveChanges();
                }
                else
                {
                    List<string> _NewCliente = new List<string>();

                    _NewCliente.Add(tbNombreCliente.Text.ToString());
                    _NewCliente.Add(tbApellidoCliente.Text.ToString());
                    _NewCliente.Add(tbCorreoElecCliente.Text.ToString());
                    _NewCliente.Add(tbSector.Text.ToString());
                    _NewCliente.Add(tbCalleCliente.Text.ToString());
                    _NewCliente.Add(tbNumeroCliente.Text.ToString());
                    _NewCliente.Add(tbRNC.Text.ToString());
                    _NewCliente.Add(tbProvincia.Text.ToString());

                    ClientesHelper _control = new ClientesHelper();
                    _control.CreateNewCliente(_NewCliente);
                    _control.SaveChanges();

                    _ThisClientID = _control.GetAll().ElementAt(_control.GetAll().Count).cliente_id;
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("No se han hechos Cambios en el perfil.", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (mtbTelefono.Text == null)
            {
                System.Windows.Forms.MessageBox.Show("Favor Ingresar un Número de Teléfono", "ERROR", MessageBoxButtons.OK);
            }
            else
            {
                ClientesHelper _OneClient = new ClientesHelper();
                Cliente _cliente = new Cliente();
                string _tel = mtbTelefono.Text.ToString();
                _cliente = _OneClient.GetOneClienteByTel(_tel);

                if (_cliente != null)
                {
                    tbNombreCliente.Text = _cliente.nombre;
                    tbApellidoCliente.Text = _cliente.apellido;
                    tbCorreoElecCliente.Text = _cliente.correo;
                    tbSector.Text = _cliente.sector;
                    tbCalleCliente.Text = _cliente.calle;
                    tbNumeroCliente.Text = _cliente.no_casa;
                    tbRNC.Text = _cliente.RNC;

                    _ThisClientID = _cliente.cliente_id;
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            tbNombreCliente.ReadOnly = false;
            tbApellidoCliente.ReadOnly = false;
            tbCorreoElecCliente.ReadOnly = false;
            tbSector.ReadOnly = false;
            tbCalleCliente.ReadOnly = false;
            tbNumeroCliente.ReadOnly = false;
            tbRNC.ReadOnly = false;
        }

        public int GetClienteID()
        {
            return _ThisClientID;
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            tbNombreCliente.ReadOnly = false;
            tbApellidoCliente.ReadOnly = false;
            tbCorreoElecCliente.ReadOnly = false;
            tbSector.ReadOnly = false;
            tbCalleCliente.ReadOnly = false;
            tbNumeroCliente.ReadOnly = false;
            tbRNC.ReadOnly = false;
        }

        private void mtbTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Error al ingresar el número de teléfono.", "ERROR", MessageBoxButtons.OK);
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llbCancelar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
