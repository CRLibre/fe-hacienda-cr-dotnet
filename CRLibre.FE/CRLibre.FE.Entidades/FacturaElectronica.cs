using System.Xml.Serialization;
using CRLibre.FE.Entidades;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2558.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://tribunet.hacienda.go.cr/docs/esquemas/2017/v4.2/facturaElectronica")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="https://tribunet.hacienda.go.cr/docs/esquemas/2017/v4.2/facturaElectronica", IsNullable=false)]
public partial class FacturaElectronica {
    
    private string claveField;
    
    private string numeroConsecutivoField;
    
    private System.DateTime fechaEmisionField;
    
    private EmisorType emisorField;
    
    private ReceptorType receptorField;
    
    private FacturaElectronicaCondicionVenta condicionVentaField;
    
    private string plazoCreditoField;
    
    private FacturaElectronicaMedioPago[] medioPagoField;
    
    private FacturaElectronicaLineaDetalle[] detalleServicioField;
    
    private FacturaElectronicaResumenFactura resumenFacturaField;
    
    private FacturaElectronicaInformacionReferencia[] informacionReferenciaField;
    
    private FacturaElectronicaNormativa normativaField;
    
    private FacturaElectronicaOtros otrosField;
    
    /// <remarks/>
    public string Clave {
        get {
            return this.claveField;
        }
        set {
            this.claveField = value;
        }
    }
    
    /// <remarks/>
    public string NumeroConsecutivo {
        get {
            return this.numeroConsecutivoField;
        }
        set {
            this.numeroConsecutivoField = value;
        }
    }
    
    /// <remarks/>
    public System.DateTime FechaEmision {
        get {
            return this.fechaEmisionField;
        }
        set {
            this.fechaEmisionField = value;
        }
    }
    
    /// <remarks/>
    public EmisorType Emisor {
        get {
            return this.emisorField;
        }
        set {
            this.emisorField = value;
        }
    }
    
    /// <remarks/>
    public ReceptorType Receptor {
        get {
            return this.receptorField;
        }
        set {
            this.receptorField = value;
        }
    }
    
    /// <remarks/>
    public FacturaElectronicaCondicionVenta CondicionVenta {
        get {
            return this.condicionVentaField;
        }
        set {
            this.condicionVentaField = value;
        }
    }
    
    /// <remarks/>
    public string PlazoCredito {
        get {
            return this.plazoCreditoField;
        }
        set {
            this.plazoCreditoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("MedioPago")]
    public FacturaElectronicaMedioPago[] MedioPago {
        get {
            return this.medioPagoField;
        }
        set {
            this.medioPagoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("LineaDetalle", IsNullable=false)]
    public FacturaElectronicaLineaDetalle[] DetalleServicio {
        get {
            return this.detalleServicioField;
        }
        set {
            this.detalleServicioField = value;
        }
    }
    
    /// <remarks/>
    public FacturaElectronicaResumenFactura ResumenFactura {
        get {
            return this.resumenFacturaField;
        }
        set {
            this.resumenFacturaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("InformacionReferencia")]
    public FacturaElectronicaInformacionReferencia[] InformacionReferencia {
        get {
            return this.informacionReferenciaField;
        }
        set {
            this.informacionReferenciaField = value;
        }
    }
    
    /// <remarks/>
    public FacturaElectronicaNormativa Normativa {
        get {
            return this.normativaField;
        }
        set {
            this.normativaField = value;
        }
    }
    
    /// <remarks/>
    public FacturaElectronicaOtros Otros {
        get {
            return this.otrosField;
        }
        set {
            this.otrosField = value;
        }
    }
}