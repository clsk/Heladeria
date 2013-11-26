//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Venta
    {
        public Venta()
        {
            this.Venta_Productos = new HashSet<Venta_Productos>();
            this.Venta_Ofertas = new HashSet<Venta_Ofertas>();
            this.NCFs = new HashSet<NCF>();
        }
    
        public long venta_id { get; set; }
        public Nullable<int> cliente_id { get; set; }
        public int caja_id { get; set; }
        public System.DateTime fecha { get; set; }
        public string forma_pago { get; set; }
        public Nullable<decimal> total { get; set; }
        public Nullable<System.DateTime> fecha_entrega { get; set; }
        public Nullable<int> entregado_por { get; set; }
        public string tarjeta_no { get; set; }
    
        public virtual Caja Caja { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual ICollection<Venta_Productos> Venta_Productos { get; set; }
        public virtual ICollection<Venta_Ofertas> Venta_Ofertas { get; set; }
        public virtual Empleado Empleado { get; set; }
        public virtual ICollection<NCF> NCFs { get; set; }
    }
}
