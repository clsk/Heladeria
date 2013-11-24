using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataLayer
{
    public class EmpleadosHelper : AbstractEntityHelper<Empleado>
    {
        public EmpleadosHelper() : base("Empleado")
        {}

        public Empleado Login(string correo, string password)
        {
            Object[] parameters = new Object[2];
            parameters[0] = new SqlParameter("@correo", correo);
            parameters[1] = new SqlParameter("@password", Utils.CalculateMD5Hash(password));
            return Provider.GetProvider().Database.SqlQuery<Empleado>("SELECT * FROM " + base._table + " WHERE correo = @correo AND password = @password", parameters).SingleOrDefault();
        }
    }

    public static class EmpleadoExtensions
    {
        public static string NombreCompleto(this Empleado empleado)
        {
            return empleado.nombre + ' ' + empleado.apellido;
        }
    }

}
