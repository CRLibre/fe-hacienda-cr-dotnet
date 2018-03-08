using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRLibre.FE.Entidades
{
    /// <summary>
    /// Tipo de dato String que solo permite el uso de números con un largo de 50.
    /// </summary>
    public class ClaveType
    {
        String clave;

        /// <summary>
        /// Tipo de dato String que solo permite el uso de números con un largo de 50.
        /// <remarks>50 caracteres obligatorios</remarks>
        /// </summary>
        public string Clave { get => clave.Substring(0,50); set => clave = value; }
    }
}
