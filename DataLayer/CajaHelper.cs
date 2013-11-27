using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataLayer
{
    public class CajaHelper : AbstractEntityHelper<Caja>
    {
        public CajaHelper() : base("Caja") { }

        public List<Caja> GetAllCajasAbiertasDeEmpleado(int empleado_id) 
        {
            return base.GetAll("empleado_id = " + empleado_id.ToString() + " AND fecha_cierra is null");
        }

        public Caja AbrirCaja(Empleado empleado, decimal cash_entrada)
        {
            Caja caja = new Caja();
            caja.empleado_id = empleado.empleado_id;
            caja.cash_entrada = cash_entrada;
            caja.fecha_abre = DateTime.Now;

            caja = Provider.GetProvider().Cajas.Add(caja);
            Provider.GetProvider().SaveChanges();
            return caja;
        }

        public decimal CalcularVentasEfectivo(int caja_id)
        {
            Object[] parameters = new Object[1];
            parameters[0] = new SqlParameter("@caja_id", caja_id);
            return Provider.GetProvider().Database.SqlQuery<decimal>("SELECT ISNULL(SUM(venta.total),0.00) FROM Venta WHERE Venta.caja_id = @caja_id AND Venta.forma_pago = 'efectivo'", parameters).SingleOrDefault();
        }

        public decimal CalcularVentasTarjeta(int caja_id)
        {
            Object[] parameters = new Object[1];
            parameters[0] = new SqlParameter("@caja_id", caja_id);
            return Provider.GetProvider().Database.SqlQuery<decimal>("SELECT ISNULL(SUM(venta.total),0.00) FROM Venta WHERE Venta.caja_id = @caja_id AND Venta.forma_pago = 'tarjeta'", parameters).SingleOrDefault();
        }

        public void Attach(Caja caja)
        {
            if (!Provider.GetProvider().ChangeTracker.Entries<Caja>().Any(x => x.Entity.caja_id == caja.caja_id))
            {
                Provider.GetProvider().Cajas.Attach(caja);
            }
        }
    }
}
