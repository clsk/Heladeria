using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public abstract class BasePersona : IPersona
    {
        /// <summary>
        /// Atributo privado que define dentro de la clase
        /// la propiedad nombre.
        /// </summary>
        private string _nombre;

        /// <summary>
        /// Implementacion correspondiente a los metodos
        /// de la propiedad Nombre.
        /// </summary>
        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }

        /// <summary>
        /// Atributo privado que define dentro de la clase
        /// la propiedad apellido.
        /// </summary>
        private string _apellido;

        /// <summary>
        /// Implementacion correspondiente a los metodos
        /// de la propiedad Apellido.
        /// </summary>
        public string Apellido
        {
            get
            {
                return _apellido;
            }
            set
            {
                _apellido = value;
            }
        }

        /// <summary>
        /// Atributo privado que define dentro de la clase
        /// la propiedad Nombre.
        /// </summary>
        private string _identificacion;

        /// <summary>
        /// Implementacion correspondiente a los metodos
        /// de la propiedad NoIdentificacion.
        /// </summary>
        public string NoIdentificacion
        {
            get
            {
                return _identificacion;
            }
            set
            {
                _identificacion = value;
            }
        }

        /// <summary>
        /// Atributo privado que define dentro de la clase
        /// la propiedad FechaImportante.
        /// </summary>
        private string _fecha;

        /// <summary>
        /// Implementacion correspondiente a los metodos
        /// de la propiedad Fecha Importante.
        /// </summary>
        public string FechaImportante
        {
            get
            {
                return _fecha;
            }
            set
            {
                _fecha = value;
            }
        }

        /// <summary>
        /// Atributo privado que define dentro de la clase
        /// la propiedad Telefono.
        /// </summary>
        private string _telefono;

        /// <summary>
        /// Implementacion correspondiente a los metodos
        /// de la propiedad Telefono.
        /// </summary>
        public string Telefono
        {
            get
            {
                return _telefono;
            }
            set
            {
                _telefono = value;
            }
        }

        /// <summary>
        /// Atributo privado que define dentro de la clase
        /// la propiedad Calle.
        /// </summary>
        private string _calle;

        /// <summary>
        /// Implementacion correspondiente a los metodos
        /// de la propiedad Calle.
        /// </summary>
        public string Calle
        {
            get
            {
                return _calle;
            }
            set
            {
                _calle = value;
            }
        }

        /// <summary>
        /// Atributo privado que define dentro de la clase
        /// la propiedad Sector.
        /// </summary>
        private string _sector;

        /// <summary>
        /// Implementacion correspondiente a los metodos
        /// de la propiedad Sector.
        /// </summary>
        public string Sector
        {
            get
            {
                return _sector;
            }
            set
            {
                _sector = value;
            }
        }

        /// <summary>
        /// Atributo privado que define dentro de la clase
        /// la propiedad Çiudad.
        /// </summary>
        private string _ciudad;

        /// <summary>
        /// Implementacion correspondiente a los metodos
        /// de la propiedad Ciudad.
        /// </summary>
        public string Ciudad
        {
            get
            {
                return _ciudad;
            }
            set
            {
                _ciudad = value;
            }
        }

        /// <summary>
        /// Atributo privado que define dentro de la clase
        /// la propiedad Provincia.
        /// </summary>
        private string _provincia;

        /// <summary>
        /// Implementacion correspondiente a los metodos
        /// de la propiedad Provincia.
        /// </summary>
        public string Provincia
        {
            get
            {
                return _provincia;
            }
            set
            {
                _provincia = value;
            }
        }

        /// <summary>
        /// Atributo privado que define dentro de la clase
        /// la propiedad Correo Electrónico.
        /// </summary>
        private string _correo;

        /// <summary>
        /// Implementacion correspondiente a los metodos
        /// de la propiedad CorreoElectronico.
        /// </summary>
        public string CorreoElectronico
        {
            get
            {
                return _correo;
            }
            set
            {
                _correo = value;
            }
        }
    }
}
