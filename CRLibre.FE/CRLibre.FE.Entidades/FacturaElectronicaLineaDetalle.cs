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
    public class FacturaElectronicaLineaDetalle
    {

        private string numeroLineaField;

        private CodigoType[] codigoField;

        private decimal cantidadField;

        private UnidadMedidaType unidadMedidaField;

        private string unidadMedidaComercialField;

        private string detalleField;

        private decimal precioUnitarioField;

        private decimal montoTotalField;

        private decimal montoDescuentoField;

        private bool montoDescuentoFieldSpecified;

        private string naturalezaDescuentoField;

        private decimal subTotalField;

        private ImpuestoType[] impuestoField;

        private decimal montoTotalLineaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string NumeroLinea
        {
            get
            {
                return this.numeroLineaField;
            }
            set
            {
                this.numeroLineaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Codigo")]
        public CodigoType[] Codigo
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
        public decimal Cantidad
        {
            get
            {
                return this.cantidadField;
            }
            set
            {
                this.cantidadField = value;
            }
        }

        /// <remarks/>
        public UnidadMedidaType UnidadMedida
        {
            get
            {
                return this.unidadMedidaField;
            }
            set
            {
                this.unidadMedidaField = value;
            }
        }

        /// <remarks/>
        public string UnidadMedidaComercial
        {
            get
            {
                return this.unidadMedidaComercialField;
            }
            set
            {
                this.unidadMedidaComercialField = value;
            }
        }

        /// <remarks/>
        public string Detalle
        {
            get
            {
                return this.detalleField;
            }
            set
            {
                this.detalleField = value;
            }
        }

        /// <remarks/>
        public decimal PrecioUnitario
        {
            get
            {
                return this.precioUnitarioField;
            }
            set
            {
                this.precioUnitarioField = value;
            }
        }

        /// <remarks/>
        public decimal MontoTotal
        {
            get
            {
                return this.montoTotalField;
            }
            set
            {
                this.montoTotalField = value;
            }
        }

        /// <remarks/>
        public decimal MontoDescuento
        {
            get
            {
                return this.montoDescuentoField;
            }
            set
            {
                this.montoDescuentoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MontoDescuentoSpecified
        {
            get
            {
                return this.montoDescuentoFieldSpecified;
            }
            set
            {
                this.montoDescuentoFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string NaturalezaDescuento
        {
            get
            {
                return this.naturalezaDescuentoField;
            }
            set
            {
                this.naturalezaDescuentoField = value;
            }
        }

        /// <remarks/>
        public decimal SubTotal
        {
            get
            {
                return this.subTotalField;
            }
            set
            {
                this.subTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Impuesto")]
        public ImpuestoType[] Impuesto
        {
            get
            {
                return this.impuestoField;
            }
            set
            {
                this.impuestoField = value;
            }
        }

        /// <remarks/>
        public decimal MontoTotalLinea
        {
            get
            {
                return this.montoTotalLineaField;
            }
            set
            {
                this.montoTotalLineaField = value;
            }
        }
    }
}
