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
    public class FacturaElectronicaNormativa
    {

        private string numeroResolucionField;

        private string fechaResolucionField;

        /// <remarks/>
        public string NumeroResolucion
        {
            get
            {
                return this.numeroResolucionField;
            }
            set
            {
                this.numeroResolucionField = value;
            }
        }

        /// <remarks/>
        public string FechaResolucion
        {
            get
            {
                return this.fechaResolucionField;
            }
            set
            {
                this.fechaResolucionField = value;
            }
        }
    }

}
