using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class VentaHelper : AbstractEntityHelper<Venta>
    {
        public VentaHelper()
            : base("Venta")
        { }

        public Venta CreateVenta(int caja_id, string forma_pago, List<Tuple<int, int>> productos, string tarjeta_no = "", int cliente_id = 0)
        {
            Venta venta = new Venta();
            venta.caja_id = caja_id;
            venta.forma_pago = forma_pago;
            venta.fecha = DateTime.Now;
            venta.total = 0m;
            if (tarjeta_no != "")
                venta.tarjeta_no = tarjeta_no;
            if (cliente_id != 0)
                venta.cliente_id = cliente_id;

            venta = Provider.GetProvider().Ventas.Add(venta);
            Provider.GetProvider().SaveChanges();

            foreach (Tuple<int, int> producto in productos)
            {
                Venta_Productos ventaProducto = new Venta_Productos();
                ventaProducto.venta_id = venta.venta_id;
                ventaProducto.producto_id = producto.Item1;
                ventaProducto.cantidad = producto.Item2;
                Provider.GetProvider().Venta_Productos.Add(ventaProducto);
                Provider.GetProvider().SaveChanges();
            }

            return venta;
        }
    }
}
