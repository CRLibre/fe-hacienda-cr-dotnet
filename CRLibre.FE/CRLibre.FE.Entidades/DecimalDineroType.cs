using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRLibre.FE.Entidades
{
    /// <summary>
    /// Tipo de dato decimal para representar los valores de dinero.
    /// </summary>
    public class DecimalDineroType
    {
        Decimal valor;

        /// <summary>
        /// Total de digitos: 18 | Total decimales: 5
        /// Valor maximo: 9999999999999.99999 | 
        /// Valor minimo: 0
        /// </summary>
        public decimal Valor {
            /*get => valor;
            set => valor = value;*/

            get => Math.Round(valor, 5);
            set => valor = value;
        
    }
    }
}
