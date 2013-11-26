using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class OrdenHelper : AbstractEntityHelper<Orden>
    {
        public OrdenHelper()
            : base("Orden")
        { }

        public Orden CrearOrden(int empleado_id, int suplidor_id, List<ProductoOrden> productos)
        {
            Orden orden = new Orden();
            orden.empleado_id = empleado_id;
            orden.suplidor_id = suplidor_id;
            orden.fecha_ordenada = DateTime.Now;
            orden = Provider.GetProvider().Ordens.Add(orden);
            Provider.GetProvider().SaveChanges();

            foreach (ProductoOrden producto in productos)
            {
                Orden_Productos orden_Producto = new Orden_Productos();
                orden_Producto.orden_id = orden.orden_id;
                orden_Producto.producto_id = producto.ProductoID;
                orden_Producto.cantidad = producto.Cantidad;
                Provider.GetProvider().Orden_Productos.Add(orden_Producto);
            }

            Provider.GetProvider().SaveChanges();

            return orden;
        }

        public void RemoveOrden(int orden_id)
        {
            Provider.GetProvider().Database.ExecuteSqlCommand("DELETE FROM Orden_Productos WHERE orden_id = " + orden_id, new object[0]);
            Provider.GetProvider().Database.ExecuteSqlCommand("DELETE FROM Orden WHERE orden_id = " + orden_id, new object[0]);
            //Provider.GetProvider().Database.SqlQuery<Object>("DELETE FROM Orden_Productos WHERE orden_id = " + orden_id, new object[0]);
            //Provider.GetProvider().Database.SqlQuery<Object>("DELETE FROM Orden WHERE orden_id = " + orden_id, new object[0]);
        }
    }
}
