using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ProductoOrden
    {
        public ProductoOrden(Producto producto)
        {
            _producto = producto;
            Ordenar = false;
            Cantidad = 0m;

            InventarioHelper inventarioHelper = new InventarioHelper();
            CantidadExistencia = inventarioHelper.GetProductoCantidad(_producto.producto_id); 
        }

        public string Nombre
        {
            get
            {
                return _producto.nombre;
            }
        }

        public string Descripcion
        {
            get
            {
                return _producto.descripcion;
            }
        }

        public decimal PrecioCompra
        {
            get
            {
                return _producto.precio_compra.Value;
            }
        }

        public bool EtiquetaNegra
        {
            get
            {
                return _producto.etiqueta_negra.HasValue ? _producto.etiqueta_negra.Value : false;
            }
        }

        public decimal CantidadExistencia
        {
            get;
            private set;
        }

        public decimal PuntoReorden
        {
            get
            {
                return _producto.punto_reorden.HasValue ? _producto.punto_reorden.Value : 0;
            }
        }

        public bool Ordenar
        {
            get;
            set;
        }

        public decimal Cantidad
        {
            get;
            set;
        }

        private Producto _producto;
    }
}
