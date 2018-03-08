using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRLibre.FE.Entidades
{
    public class TelefonoType
    {
        Int32 codigoPais;
        Int32 numTelefono;

        /// <summary>
        /// Código del país
        /// <remarks>3 digitos máximo</remarks>
        /// </summary>
        public int CodigoPais { get => codigoPais; set => codigoPais = value; }

        /// <summary>
        /// Número de teléfono
        /// <remarks>20 caracteres máximo</remarks>
        /// </summary>
        public int NumTelefono { get => numTelefono; set => numTelefono = value; }
    }
}
