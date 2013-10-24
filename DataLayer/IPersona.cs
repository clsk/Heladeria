using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
        public interface IPersona
        {
            /// <summary>
            /// Propiedad que define el Nombre de una Persona
            /// </summary>
            string Nombre { get; set; }

            /// <summary>
            /// Propiedad que define el Apellido de una Persona
            /// </summary>
            string Apellido { get; set; }

            /// <summary>
            /// Propiedad que define el Numero de Identificación de una Persona.
            /// </summary>
            /// <remarks>
            /// Esta propiedad adimite el empleo de RNC y Cedula.
            /// </remarks>
            string NoIdentificacion { get; set; }

            /// <summary>
            /// Propiedad para deifinir Fecha Importante Respecto a una Persona.
            /// </summary>
            /// <remarks>
            /// Esta propiedad admite el empleo de Fecha de Ingreso y Fecha de Nacimiento.
            /// </remarks>
            string FechaImportante { get; set; }

            /// <summary>
            /// Propiedad que define el Numero de Telefono de una Persona
            /// </summary>
            string Telefono { get; set; }

            /// <summary>
            /// Propiedad que define la Calle en la que Reside una Persona
            /// </summary>
            string Calle { get; set; }

            /// <summary>
            /// Propiedad que define el Sector en el que Reside una Persona.
            /// </summary>
            string Sector { get; set; }

            /// <summary>
            /// Propiedad que define la Ciudad en que vive una Persona.
            /// </summary>
            string Ciudad { get; set; }

            /// <summary>
            /// Propiedad que define la Provincia en que vive una Persona.
            /// </summary>
            string Provincia { get; set; }

            /// <summary>
            /// Propiedad que define el Correo Electronico de una Persona.
            /// </summary>
            /// <remarks>
            /// Es importante tener otras formas de contactar con una Persona.
            /// </remarks>
            string CorreoElectronico { get; set; }
        }
}
