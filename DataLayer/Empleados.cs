using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataLayer
{
    public class Empleados
    {
        public static List<Empleado> GetAll()
        {
            try
            {
                List<Empleado> empleados = Provider.GetProvider().Database.SqlQuery<Empleado>("SELECT * FROM Empleado", new object[0]).ToList();
                return empleados;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Empleado Login(string correo, string password)
        {
            Object[] parameters = new Object[2];
            parameters[0] = new SqlParameter("@correo", correo);
            parameters[1] = new SqlParameter("@password", Utils.CalculateMD5Hash(password));
            return Provider.GetProvider().Database.SqlQuery<Empleado>("SELECT * FROM Empleado WHERE correo = @correo AND password = @password", parameters).Single();
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
