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
    
    public partial class Caja
    {
        public Caja()
        {
            this.Ventas = new HashSet<Venta>();
        }
    
        public int caja_id { get; set; }
        public int empleado_id { get; set; }
        public decimal cash_entrada { get; set; }
        public System.DateTime fecha_abre { get; set; }
        public Nullable<System.DateTime> fecha_cierra { get; set; }
    
        public virtual Empleado Empleado { get; set; }
        public virtual ICollection<Venta> Ventas { get; set; }
    }
}
