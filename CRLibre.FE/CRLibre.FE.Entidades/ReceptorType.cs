using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CRLibre.FE.Entidades
{
    public class ReceptorType
    {
        String nombre;
        IdentificacionType identificacion;
        String identificacionExtranjero;
        String nombreComercial;
        UbicacionType ubicacion;
        TelefonoType telefono;
        TelefonoType fax;
        String correoElectronico;

        /// <summary>
        /// Nombre o razon social
        /// [REQUERIDO]
        /// <remarks>80 caracteres máximo</remarks>
        /// </summary>
        public string Nombre { get => nombre; set => nombre = value; }
        public IdentificacionType Identificacion { get => identificacion; set => identificacion = value; }

        /// <summary>
        /// Este campo será de condición obligatoria, cuando el cliente lo requiera
        /// <remarks>20 caracteres máximo</remarks>
        /// </summary>
        public string IdentificacionExtranjero { get => identificacionExtranjero; set => identificacionExtranjero = value; }

        /// <summary>
        /// En caso de que se cuente con nombre comercial debe indicarse
        /// <remarks>80 caracteres máximo</remarks>
        /// </summary>
        public string NombreComercial { get => nombreComercial; set => nombreComercial = value; }

        public UbicacionType Ubicacion { get => ubicacion; set => ubicacion = value; }

        /// <summary>
        /// No es obligatorio
        /// </summary>
        public TelefonoType Telefono { get => telefono; set => telefono = value; }

        /// <summary>
        /// No es obligatorio
        /// </summary>
        public TelefonoType Fax { get => fax; set => fax = value; }

        /// <summary>
        /// Debe cumplir con la siguiente estructura:  \s*\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*\s*
        /// </summary>
        public string CorreoElectronico
        {
            get { return correoElectronico; }
            set
            {
                Regex formatoEmail = new Regex(@"\s*\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*\s*");

                if (formatoEmail.IsMatch(value))

                    correoElectronico = value;

                else

                    throw new Exception("El formato de correo no es valido, favor verificar: " + value.ToString());

            }
        }
    }
}
