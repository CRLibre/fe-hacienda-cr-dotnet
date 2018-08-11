using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRLibre.FE.Entidades
{
    /// <summary>
    /// Condiciones de la venta
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2558.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "https://tribunet.hacienda.go.cr/docs/esquemas/2017/v4.2/facturaElectronica")]
    public enum FacturaElectronicaCondicionVenta
    {

        /// <summary>
        /// Contado
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Contado,

        /// <summary>
        /// Crédito
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Crédito,

        /// <summary>
        /// Consignación
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("03")]
        Consignación,

        /// <summary>
        /// Apartado
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Apartado,

        /// <summary>
        /// Arrendamiento con opción de compra
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("05")]
        Arrendamiento_con_opción_de_compra,

        /// <summary>
        /// Arrendamiento en función financiera
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("06")]
        Arrendamiento_en_función_financiera,

        /// <summary>
        /// Otros
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("99")]
        Otros,
    }
}
