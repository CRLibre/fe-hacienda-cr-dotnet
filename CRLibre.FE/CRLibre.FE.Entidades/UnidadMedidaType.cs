using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRLibre.FE.Entidades
{
    /// <summary>
    /// Unidades de Medida basadas en el estándar RTC 443:2010
    /// </summary>
    public class UnidadMedidaType
    {

        String medida;

        /// <summary>
        /// [NO OFICIAL DE HACIENDA]
        /// Indica el tipo de medida utilizada, 
        /// <example>Sp=Servicios Profesionales, m=Metro, etc</example>
        /// </summary>
        public string Medida { get => medida; set => medida = value; }
    }
}
