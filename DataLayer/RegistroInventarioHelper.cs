using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class RegistroInventarioHelper : AbstractEntityHelper<RegistroInventario>
    {
        public RegistroInventarioHelper()
            : base("RegistroInventario")
        { }

        public RegistroInventario CrearRegistro(int empleado_id, List<ProductoInventario> productos)
        {
            RegistroInventario registro = new RegistroInventario();
            registro.empleado_id = empleado_id;
            registro.fecha = DateTime.Now;
            registro = Provider.GetProvider().RegistroInventarios.Add(registro);
            Provider.GetProvider().SaveChanges();

            foreach (ProductoInventario producto in productos)
            {
                RegistroInventario_Productos registro_Producto = new RegistroInventario_Productos();
                registro_Producto.inventario_id = registro.inventario_id;
                registro_Producto.producto_id = producto.ProductoID;
                registro_Producto.cantidad = producto.CantidadExistencia;
                Provider.GetProvider().RegistroInventario_Productos.Add(registro_Producto);
            }

            Provider.GetProvider().SaveChanges();

            return registro;
        }
    }
}
