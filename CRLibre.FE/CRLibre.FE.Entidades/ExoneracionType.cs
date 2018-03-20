using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRLibre.FE.Entidades
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2558.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://tribunet.hacienda.go.cr/docs/esquemas/2017/v4.2/facturaElectronica")]
    public class ExoneracionType
    {

        private ExoneracionTypeTipoDocumento tipoDocumentoField;

        private string numeroDocumentoField;

        private string nombreInstitucionField;

        private System.DateTime fechaEmisionField;

        private decimal montoImpuestoField;

        private string porcentajeCompraField;

        /// <remarks/>
        public ExoneracionTypeTipoDocumento TipoDocumento
        {
            get
            {
                return this.tipoDocumentoField;
            }
            set
            {
                this.tipoDocumentoField = value;
            }
        }

        /// <remarks/>
        public string NumeroDocumento
        {
            get
            {
                return this.numeroDocumentoField;
            }
            set
            {
                this.numeroDocumentoField = value;
            }
        }

        /// <remarks/>
        public string NombreInstitucion
        {
            get
            {
                return this.nombreInstitucionField;
            }
            set
            {
                this.nombreInstitucionField = value;
            }
        }

        /// <remarks/>
        public System.DateTime FechaEmision
        {
            get
            {
                return this.fechaEmisionField;
            }
            set
            {
                this.fechaEmisionField = value;
            }
        }

        /// <remarks/>
        public decimal MontoImpuesto
        {
            get
            {
                return this.montoImpuestoField;
            }
            set
            {
                this.montoImpuestoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string PorcentajeCompra
        {
            get
            {
                return this.porcentajeCompraField;
            }
            set
            {
                this.porcentajeCompraField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2558.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "https://tribunet.hacienda.go.cr/docs/esquemas/2017/v4.2/facturaElectronica")]
    public enum ExoneracionTypeTipoDocumento
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("03")]
        Item03,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Item04,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("05")]
        Item05,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("99")]
        Item99,
    }
}
