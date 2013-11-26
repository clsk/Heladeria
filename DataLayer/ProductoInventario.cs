using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DataLayer
{
    public class ProductoInventario
    {
        public ProductoInventario(Producto producto)
        {
            Producto = producto;
            InventarioHelper inventarioHelper = new InventarioHelper();
            CantidadExistencia = inventarioHelper.GetProductoCantidad(Producto.producto_id);
            ModificarCantidad = false;
        }

        public int ProductoID
        {
            get
            {
                return Producto.producto_id;
            }
        }

        public string Nombre
        {
            get
            {
                return Producto.nombre;
            }
        }

        public bool EtiquetaNegra
        {
            get
            {
                return Producto.etiqueta_negra.HasValue ? Producto.etiqueta_negra.Value : false;
            }
        }
        public string Descripcion
        {
            get
            {
                return Producto.descripcion;
            }
        }

        public bool ModificarCantidad
        {
            get;
            set;
        }

        public decimal CantidadExistencia
        {
            get;
            set;
        }

        [Browsable(false)]
        public Producto Producto
        {
            get;
            private set;
        }
    }
}
