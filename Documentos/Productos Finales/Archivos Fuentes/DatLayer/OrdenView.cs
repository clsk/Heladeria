using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DataLayer
{
    public class OrdenView
    {
        public OrdenView(Orden orden)
        {
            _orden = orden;
            SuplidorHelper suplidorHelper = new SuplidorHelper();
            EmpleadosHelper empleadoHelper = new EmpleadosHelper();
            Suplidor = suplidorHelper.Get(_orden.suplidor_id).nombre;
            Empleado = empleadoHelper.Get(_orden.empleado_id).NombreCompleto();
        }

        public string FechaOrden
        {
            get
            {
                return _orden.fecha_ordenada.ToString();
            }
        }

        public string Empleado
        {
            get;
            private set;
        }

        public string Suplidor
        {
            get;
            private set;
        }

        public string Estado
        {
            get
            {
                if (_orden.recibida.HasValue && _orden.recibida.Value)
                    return "Recibida";
                else if (_orden.despachada.HasValue && _orden.despachada.Value)
                    return "Despachada";
                else if (_orden.aceptada.HasValue && _orden.aceptada.Value)
                    return "Aceptada";
                else
                    return "Ordenada";
            }
        }

        public string FechaUltimaAccion
        {
            get
            {
                string estado = Estado;
                if (estado == "Recibida")
                    return _orden.fecha_recibida.HasValue ? _orden.fecha_recibida.Value.ToString() : "";
                else if (estado == "Despachada")
                    return _orden.fecha_despachada.HasValue ? _orden.fecha_despachada.Value.ToString() : "";
                else if (estado == "Aceptada")
                    return _orden.fecha_aceptada.HasValue ? _orden.fecha_aceptada.Value.ToString() : "";
                else
                    return FechaOrden;
            }
        }

        [Browsable(false)]
        public Orden Orden
        {
            get
            {
                return _orden;
            }
        }

        private Orden _orden;
    }
}
