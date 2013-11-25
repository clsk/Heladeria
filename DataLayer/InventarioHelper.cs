using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class InventarioHelper : AbstractEntityHelper<RegistroInventario>
    {
        public InventarioHelper()
            : base("RegistroInventario")
        { }

        public decimal GetProductoCantidad(int producto_id)
        {
            string query = "SELECT ISNULL((SELECT TOP 1 cantidad FROM RegistroInventario_Productos INNER JOIN RegistroInventario ON RegistroInventario_Productos.inventario_id = RegistroInventario.inventario_id WHERE RegistroInventario_Productos.producto_id = " + producto_id + " ORDER BY RegistroInventario.fecha DESC), 0) AS Cantidad";
            return Provider.GetProvider().Database.SqlQuery<decimal>(query, new object[0]).Single();
        }
    }
}
