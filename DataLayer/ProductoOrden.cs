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

        public decimal PrecioVenta
        {
            get
            {
                return _producto.precio_venta.Value;
            }
        }

        public bool EtiquetaNegra
        {
            get
            {
                return _producto.etiqueta_negra.Value;
            }
        }

        public decimal PuntoReorden
        {
            get
            {
                return _producto.punto_reorden.Value;
            }
        }

        public string Suplidor
        {
            get;
            set;
        }

        private Producto _producto;
    }
}
