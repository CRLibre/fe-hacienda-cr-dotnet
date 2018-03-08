using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRLibre.FE.Entidades
{
    public class CodigoType
    {
        String tipo;
        String codigo;

        /// <summary>
        /// Tipo de código de producto o servicio: 
        /// 01: Código del producto del vendedor, 
        /// 02 Código del producto del comprador, 
        /// 03 Código del producto asignado por la industria, 
        /// 04 Código de uso interno, 
        /// 99 Otros
        /// <remarks>2 caracteres obligatorios</remarks>
        /// </summary>
        public string Tipo { get => tipo; set => tipo = value; }

        /// <summary>
        /// Código del producto o servicio
        /// <remarks>20 caracteres obligatorios</remarks>
        /// </summary>
        public string Codigo { get => codigo; set => codigo = value; }
    }
}
