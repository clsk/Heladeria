using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataLayer
{
    public class ClientesHelper : AbstractEntityHelper<Cliente>
    {
        public ClientesHelper() : base ("Cliente"){
    
        }

        public Cliente GetOneClienteByTel(string _telCliente) {
            Object parameters = new Object();
            parameters = new SqlParameter("@ClienteTel", _telCliente);
            string QueryLine = "SELECT * FROM" + base._table + "WHERE telefono = @ClienteTel";
            return Provider.GetProvider().Database.SqlQuery<Cliente>(QueryLine, parameters).SingleOrDefault();
        }

        public void CreateNewCliente(List<string> DataOfCliente)
        {
            Cliente cliente = new Cliente();

            cliente.nombre = DataOfCliente.ElementAt(0);
            cliente.apellido = DataOfCliente.ElementAt(1);
            cliente.correo = DataOfCliente.ElementAt(2);
            cliente.sector = DataOfCliente.ElementAt(3);
            cliente.calle = DataOfCliente.ElementAt(4);
            cliente.no_casa = DataOfCliente.ElementAt(5);
            cliente.RNC = DataOfCliente.ElementAt(6);
            cliente.provincia = DataOfCliente.ElementAt(7);

            cliente = Provider.GetProvider().Clientes.Add(cliente);
            Provider.GetProvider().SaveChanges();
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
