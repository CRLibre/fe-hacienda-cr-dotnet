using System.Xml.Serialization;
using CRLibre.FE.Entidades;

/// <summary>
/// Elemento Raiz de la Facturacion Electrónica
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2558.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://tribunet.hacienda.go.cr/docs/esquemas/2017/v4.2/facturaElectronica")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="https://tribunet.hacienda.go.cr/docs/esquemas/2017/v4.2/facturaElectronica", IsNullable=false)]
public partial class FacturaElectronica {

    #region Variables 

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

    #endregion

    #region Metodos

    /// <summary>
    /// Corresponde a la clave del comprobante. Es un campo de 50 posiciones y se tiene que utilizar para la consulta del código QR. Ver nota 1 y 4.1
    ///  | [REQUERIDO]
    /// </summary>
    public string Clave {
        get {
            return this.claveField.Substring(0, 50);
        }
        set {
            this.claveField = value;
        }
    }

    /// <summary>
    /// Numeración consecutiva del comprobante, Tipo de dato String que solo permite el uso de números con un largo de 20
    ///  | [REQUERIDO]
    /// </summary>
    public string NumeroConsecutivo {
        get {
            return this.numeroConsecutivoField.Substring(0,20);
        }
        set {
            this.numeroConsecutivoField = value;
        }
    }

    /// <summary>
    /// Basado en el standard en formato RFC 3339, sección 5.6 tipo "date-time". Formato: YYYY-MM-DDThh:mi:ss[Z|(+|-)hh:mm] | 
    /// Ejemplo: 2016-09-26T13:00:00+06:00 | C#: private const string format = "yyyy-MM-dd'T'HH:mm:ss.fffK";
    /// </summary>
    public System.DateTime FechaEmision {
        get {
            return this.fechaEmisionField;
        }
        set {
            this.fechaEmisionField = value;
        }
    }

    /// <summary>
    /// Emisor del documento
    ///  | [REQUERIDO]
    /// </summary>
    public EmisorType Emisor {
        get {
            return this.emisorField;
        }
        set {
            this.emisorField = value;
        }
    }

    /// <summary>
    /// Receptor del documento
    /// [OPCIONAL]
    /// </summary>
    public ReceptorType Receptor {
        get {
            return this.receptorField;
        }
        set {
            this.receptorField = value;
        }
    }

    /// <summary>
    /// Condiciones de la venta: 
    /// 01 Contado, 
    /// 02 Crédito, 
    /// 03 Consignación, 
    /// 04 Apartado, 
    /// 05 Arrendamiento con opción de compra, 
    /// 06 Arrendamiento en función financiera, 
    /// 99 Otros
    /// </summary>
    public FacturaElectronicaCondicionVenta CondicionVenta {
        get {
            return this.condicionVentaField;
        }
        set {
            this.condicionVentaField = value;
        }
    }

    /// <summary>
    /// Plazo del crédito, es obligatorio cuando la venta del producto o prestación del servicio sea a crédito
    /// [OPCIONAL]
    /// </summary>
    public string PlazoCredito {
        get {
            return this.plazoCreditoField;
        }
        set {
            this.plazoCreditoField = value;
        }
    }

    /// <summary>
    /// Corresponde al medio de pago empleado: 
    /// 01 Efectivo, 
    /// 02 Tarjeta, 
    /// 03 Cheque, 
    /// 04 Transferencia - depósito bancario, 
    /// 05 - Recaudado por terceros, 
    /// 99 Otros
    /// De 1 a 4 repeticiones
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute("MedioPago")]
    public FacturaElectronicaMedioPago[] MedioPago {
        get {
            return this.medioPagoField;
        }
        set {
            this.medioPagoField = value;
        }
    }

    /// <summary>
    /// Detalle de la mercancia o servicio prestado.
    /// De 1 a 1000 repeticiones
    /// </summary>
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

    /// <summary>
    /// Tipo de documento de referencia. 01 Factura electrónica, 02 Nota de débito electrónica, 03 nota de crédito electrónica, 04 Tiquete electrónico, 05 Nota de despacho, 06 Contrato, 07 Procedimiento, 08 Comprobante emitido en contigencia, 99 Otros
    /// [OPCIONAL] de 1 a 10 repeticiones
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute("InformacionReferencia")]
    public FacturaElectronicaInformacionReferencia[] InformacionReferencia {
        get {
            return this.informacionReferenciaField;
        }
        set {
            this.informacionReferenciaField = value;
        }
    }

    /// <summary>
    /// Normativa vigente
    /// </summary>
    public FacturaElectronicaNormativa Normativa {
        get {
            return this.normativaField;
        }
        set {
            this.normativaField = value;
        }
    }

    /// <summary>
    /// Elemento opcional que se puede utilizar la almacenar texto.
    /// [OPCIONAL]
    /// </summary>
    public FacturaElectronicaOtros Otros {
        get {
            return this.otrosField;
        }
        set {
            this.otrosField = value;
        }
    }

    #endregion
}