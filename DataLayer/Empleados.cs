using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Empleados
    {
        public static List<Empleado> GetEmpleados()
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
    }
}
