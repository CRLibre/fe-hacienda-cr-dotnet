using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRLibre.FE.Entidades
{
    public class UbicacionType
    {
        String provincia;
        String canton;
        String distrito;
        String barrio;
        String otrasSenas;

        /// <summary>
        /// <remarks>160 caracteres máximo</remarks>
        /// </summary>
        public string OtrasSenas { get => otrasSenas; set => otrasSenas = value; }
        /// <summary>
        /// <remarks>2 caracteres máximo</remarks>
        /// </summary>
        public string Barrio { get => barrio; set => barrio = value; }

        /// <summary>
        /// <remarks>2 caracteres máximo</remarks>
        /// </summary>
        public string Distrito { get => distrito; set => distrito = value; }

        /// <summary>
        /// <remarks>2 caracteres máximo</remarks>
        /// </summary>
        public string Canton { get => canton; set => canton = value; }

        /// <summary>
        /// <remarks>2 caracteres máximo</remarks>
        /// </summary>
        public string Provincia { get => provincia; set => provincia = value; }
    }
}
