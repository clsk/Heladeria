using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class ClientsRecord : Form
    {
        public ClientsRecord()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            /*
             * TODO:
             *  Realizar una creacion de un objeto para enviarlo
             *  a la base de datos.
             */
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            /*
             * TODO:
             *  Realizar algoritmo de busqueda.
             *  Indicando el numero de telefono del cliente.
             */
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            /*
             * TODO:
             *  Habilitar campos para escribir las informaciones
             *  nuevas del cliente.
             */
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {

        }
    }
}
