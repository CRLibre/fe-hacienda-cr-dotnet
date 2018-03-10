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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "https://tribunet.hacienda.go.cr/docs/esquemas/2017/v4.2/facturaElectronica")]
    public class FacturaElectronicaInformacionReferencia
    {

        private FacturaElectronicaInformacionReferenciaTipoDoc tipoDocField;

        private string numeroField;

        private System.DateTime fechaEmisionField;

        private FacturaElectronicaInformacionReferenciaCodigo codigoField;

        private string razonField;

        /// <remarks/>
        public FacturaElectronicaInformacionReferenciaTipoDoc TipoDoc
        {
            get
            {
                return this.tipoDocField;
            }
            set
            {
                this.tipoDocField = value;
            }
        }

        /// <remarks/>
        public string Numero
        {
            get
            {
                return this.numeroField;
            }
            set
            {
                this.numeroField = value;
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
        public FacturaElectronicaInformacionReferenciaCodigo Codigo
        {
            get
            {
                return this.codigoField;
            }
            set
            {
                this.codigoField = value;
            }
        }

        /// <remarks/>
        public string Razon
        {
            get
            {
                return this.razonField;
            }
            set
            {
                this.razonField = value;
            }
        }
    }

}
