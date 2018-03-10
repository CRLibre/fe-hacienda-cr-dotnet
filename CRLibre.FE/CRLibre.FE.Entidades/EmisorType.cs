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
    public class EmisorType
    {

        private string nombreField;

        private IdentificacionType identificacionField;

        private string nombreComercialField;

        private UbicacionType ubicacionField;

        private TelefonoType telefonoField;

        private TelefonoType faxField;

        private string correoElectronicoField;

        /// <remarks/>
        public string Nombre
        {
            get
            {
                return this.nombreField;
            }
            set
            {
                this.nombreField = value;
            }
        }

        /// <remarks/>
        public IdentificacionType Identificacion
        {
            get
            {
                return this.identificacionField;
            }
            set
            {
                this.identificacionField = value;
            }
        }

        /// <remarks/>
        public string NombreComercial
        {
            get
            {
                return this.nombreComercialField;
            }
            set
            {
                this.nombreComercialField = value;
            }
        }

        /// <remarks/>
        public UbicacionType Ubicacion
        {
            get
            {
                return this.ubicacionField;
            }
            set
            {
                this.ubicacionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public TelefonoType Telefono
        {
            get
            {
                return this.telefonoField;
            }
            set
            {
                this.telefonoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public TelefonoType Fax
        {
            get
            {
                return this.faxField;
            }
            set
            {
                this.faxField = value;
            }
        }

        /// <remarks/>
        public string CorreoElectronico
        {
            get
            {
                return this.correoElectronicoField;
            }
            set
            {
                this.correoElectronicoField = value;
            }
        }
    }

}
