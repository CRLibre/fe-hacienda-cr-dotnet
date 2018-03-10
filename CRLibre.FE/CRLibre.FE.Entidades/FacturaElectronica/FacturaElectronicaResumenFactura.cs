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
    public class FacturaElectronicaResumenFactura
    {

        private FacturaElectronicaResumenFacturaCodigoMoneda codigoMonedaField;

        private bool codigoMonedaFieldSpecified;

        private decimal tipoCambioField;

        private bool tipoCambioFieldSpecified;

        private decimal totalServGravadosField;

        private bool totalServGravadosFieldSpecified;

        private decimal totalServExentosField;

        private bool totalServExentosFieldSpecified;

        private decimal totalMercanciasGravadasField;

        private bool totalMercanciasGravadasFieldSpecified;

        private decimal totalMercanciasExentasField;

        private bool totalMercanciasExentasFieldSpecified;

        private decimal totalGravadoField;

        private bool totalGravadoFieldSpecified;

        private decimal totalExentoField;

        private bool totalExentoFieldSpecified;

        private decimal totalVentaField;

        private decimal totalDescuentosField;

        private bool totalDescuentosFieldSpecified;

        private decimal totalVentaNetaField;

        private decimal totalImpuestoField;

        private bool totalImpuestoFieldSpecified;

        private decimal totalComprobanteField;

        /// <remarks/>
        public FacturaElectronicaResumenFacturaCodigoMoneda CodigoMoneda
        {
            get
            {
                return this.codigoMonedaField;
            }
            set
            {
                this.codigoMonedaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CodigoMonedaSpecified
        {
            get
            {
                return this.codigoMonedaFieldSpecified;
            }
            set
            {
                this.codigoMonedaFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal TipoCambio
        {
            get
            {
                return this.tipoCambioField;
            }
            set
            {
                this.tipoCambioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TipoCambioSpecified
        {
            get
            {
                return this.tipoCambioFieldSpecified;
            }
            set
            {
                this.tipoCambioFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal TotalServGravados
        {
            get
            {
                return this.totalServGravadosField;
            }
            set
            {
                this.totalServGravadosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalServGravadosSpecified
        {
            get
            {
                return this.totalServGravadosFieldSpecified;
            }
            set
            {
                this.totalServGravadosFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal TotalServExentos
        {
            get
            {
                return this.totalServExentosField;
            }
            set
            {
                this.totalServExentosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalServExentosSpecified
        {
            get
            {
                return this.totalServExentosFieldSpecified;
            }
            set
            {
                this.totalServExentosFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal TotalMercanciasGravadas
        {
            get
            {
                return this.totalMercanciasGravadasField;
            }
            set
            {
                this.totalMercanciasGravadasField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalMercanciasGravadasSpecified
        {
            get
            {
                return this.totalMercanciasGravadasFieldSpecified;
            }
            set
            {
                this.totalMercanciasGravadasFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal TotalMercanciasExentas
        {
            get
            {
                return this.totalMercanciasExentasField;
            }
            set
            {
                this.totalMercanciasExentasField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalMercanciasExentasSpecified
        {
            get
            {
                return this.totalMercanciasExentasFieldSpecified;
            }
            set
            {
                this.totalMercanciasExentasFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal TotalGravado
        {
            get
            {
                return this.totalGravadoField;
            }
            set
            {
                this.totalGravadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalGravadoSpecified
        {
            get
            {
                return this.totalGravadoFieldSpecified;
            }
            set
            {
                this.totalGravadoFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal TotalExento
        {
            get
            {
                return this.totalExentoField;
            }
            set
            {
                this.totalExentoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalExentoSpecified
        {
            get
            {
                return this.totalExentoFieldSpecified;
            }
            set
            {
                this.totalExentoFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal TotalVenta
        {
            get
            {
                return this.totalVentaField;
            }
            set
            {
                this.totalVentaField = value;
            }
        }

        /// <remarks/>
        public decimal TotalDescuentos
        {
            get
            {
                return this.totalDescuentosField;
            }
            set
            {
                this.totalDescuentosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalDescuentosSpecified
        {
            get
            {
                return this.totalDescuentosFieldSpecified;
            }
            set
            {
                this.totalDescuentosFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal TotalVentaNeta
        {
            get
            {
                return this.totalVentaNetaField;
            }
            set
            {
                this.totalVentaNetaField = value;
            }
        }

        /// <remarks/>
        public decimal TotalImpuesto
        {
            get
            {
                return this.totalImpuestoField;
            }
            set
            {
                this.totalImpuestoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalImpuestoSpecified
        {
            get
            {
                return this.totalImpuestoFieldSpecified;
            }
            set
            {
                this.totalImpuestoFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal TotalComprobante
        {
            get
            {
                return this.totalComprobanteField;
            }
            set
            {
                this.totalComprobanteField = value;
            }
        }
    }
}
