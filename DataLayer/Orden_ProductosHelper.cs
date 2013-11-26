using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Orden_ProductosHelper : AbstractEntityHelper<Orden_Productos>
    {
        public Orden_ProductosHelper()
            : base("Orden_Productos")
        { }

        public List<Orden_Productos> GetAllFromOrden(int orden_id)
        {
            return base.GetAll("orden_id = " + orden_id);
        }
    }
}
