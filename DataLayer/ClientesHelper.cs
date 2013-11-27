using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataLayer
{
    class ClientesHelper : AbstractEntityHelper<Cliente>
    {
        public ClientesHelper() : base ("Cliente"){
    
        }

        public Cliente GetOneCliente(string _telCliente) {
            Object parameters = new Object();
            parameters = new SqlParameter("@ClienteTel", _telCliente);
            string QueryLine = "SELECT * FROM" + base._table + "WHERE telefono = @ClienteTel";
            return Provider.GetProvider().Database.SqlQuery<Cliente>(QueryLine, parameters).SingleOrDefault();
        }

        public void Attach(Cliente _cliente)
        {
            Provider.GetProvider().Clientes.Attach(_cliente);
        }
    }

    public static class ClienteExtensions 
    {
        public static string NombreComplCliente (this Cliente _cliente){
            return _cliente.nombre + " " + _cliente.apellido;
        }

        public static string ClienteRNC (this Cliente _cliente){
            return _cliente.RNC;
        }
    }
}
