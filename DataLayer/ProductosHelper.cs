using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ProductosHelper : AbstractEntityHelper<Producto>
    {
        public ProductosHelper()
            : base("Producto")
        { }

        public List<Producto> GetAllProductosParaVenta()
        {
            return base.GetAll("precio_venta is not null");
        }
    }
}
