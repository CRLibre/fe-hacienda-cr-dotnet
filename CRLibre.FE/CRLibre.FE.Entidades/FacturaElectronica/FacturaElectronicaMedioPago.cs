using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRLibre.FE.Entidades
{
    /// <summary>
    /// Corresponde al medio de pago empleado: 
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2558.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "https://tribunet.hacienda.go.cr/docs/esquemas/2017/v4.2/facturaElectronica")]
    public enum FacturaElectronicaMedioPago
    {

        /// <summary>
        /// Efectivo
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Efectivo,

        /// <summary>
        /// Tarjeta
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Tarjeta,

        /// <summary>
        /// Cheque
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("03")]
        Cheque,

        /// <summary>
        /// Transferencia - depósito bancario
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Transferencia_depósito_bancario,

        /// <summary>
        /// Recaudado por terceros
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("05")]
        Recaudado_por_terceros,

        /// <summary>
        /// Otros
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("99")]
        Otros,
    }
}
