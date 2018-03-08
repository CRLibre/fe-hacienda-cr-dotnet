using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRLibre.FE.Entidades
{
    public class IdentificacionType
    {
        String tipo;
        String numero;
        /// <summary>
        /// Tipo de identificación: [REQUERIDO] 01 Cédula Física, 02 Cédula Jurídica, 03 DIMEX, 04 NITE
        /// <remarks> 2 caracteres obligatorios</remarks>
        /// </summary>
        public string Tipo { get => tipo.Substring(0,2); set => tipo = value; }

        /// <summary>
        /// Número de identificación, el contribuyente debe estar inscrito ante la Administración Tributaria
        /// <remarks>Nota: Debe contener entre 9 y 12 caracteres</remarks>
        /// </summary>
        public string Numero { get => numero; set => numero = value; }
    }
}
