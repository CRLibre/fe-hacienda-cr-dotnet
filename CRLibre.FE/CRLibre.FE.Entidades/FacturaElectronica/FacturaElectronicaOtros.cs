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
    public class FacturaElectronicaOtros
    {

        private FacturaElectronicaOtrosOtroTexto[] otroTextoField;

        private FacturaElectronicaOtrosOtroContenido[] otroContenidoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OtroTexto")]
        public FacturaElectronicaOtrosOtroTexto[] OtroTexto
        {
            get
            {
                return this.otroTextoField;
            }
            set
            {
                this.otroTextoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OtroContenido")]
        public FacturaElectronicaOtrosOtroContenido[] OtroContenido
        {
            get
            {
                return this.otroContenidoField;
            }
            set
            {
                this.otroContenidoField = value;
            }
        }
    }

}
