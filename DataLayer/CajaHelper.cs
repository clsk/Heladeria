using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class CajaHelper : AbstractEntityHelper<Caja>
    {
        public CajaHelper() : base("Caja") { }

        public List<Caja> GetAllCajasAbiertasDeEmpleado(int empleado_id) 
        {
            return base.GetAll("empleado_id = " + empleado_id.ToString() + " AND estado = 1");
        }
    }
}
