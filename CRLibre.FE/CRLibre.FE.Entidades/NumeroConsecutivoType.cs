using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRLibre.FE.Entidades
{
    /// <summary>
    /// 
    /// </summary>
    public class NumeroConsecutivoType
    {
        String numeroConsecutivo;

        /// <summary>
        /// Tipo de dato String que solo permite el uso de números con un largo de 20
        /// <remarks>20 caracteres máximo</remarks>
        /// </summary>
        public string NumeroConsecutivo { get => numeroConsecutivo.Substring(0,20); set => numeroConsecutivo = value; }
    }
}
