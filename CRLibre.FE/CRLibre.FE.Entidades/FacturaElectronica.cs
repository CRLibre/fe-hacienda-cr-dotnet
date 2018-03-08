using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRLibre.FE.Entidades
{
    /// <summary>
    /// Elemento raíz de la factura electronica
    /// </summary>
    public class FacturaElectronica
    {
        ClaveType clave;
        NumeroConsecutivoType numeroConsecutivo;
        DateTime fechaEmision;
        EmisorType emisor;
        ReceptorType receptor;
        String condicionVenta;
        String plazoCredito;
        List<MedioPagoType> lstMedioPago;//puede ser de 1 a 4 repeticiones
        String detalleServicio;

        /// <summary>
        /// Corresponde a la clave del comprobante. Es un campo de 50 posiciones y se tiene que utilizar para la consulta del código QR. Ver nota 1 y 4.1
        /// </summary>
        public ClaveType Clave { get => clave; set => clave = value; }

        /// <summary>
        /// Numeración consecutiva del comprobante
        /// </summary>
        public NumeroConsecutivoType NumeroConsecutivo { get => numeroConsecutivo; set => numeroConsecutivo = value; }
        public DateTime FechaEmision { get => fechaEmision; set => fechaEmision = value; }

        /// <summary>
        /// Emisor del documento
        /// </summary>
        public EmisorType Emisor { get => emisor; set => emisor = value; }

        /// <summary>
        /// Receptor del documento [OPCIONAL]
        /// </summary>
        public ReceptorType Receptor { get => receptor; set => receptor = value; }

        /// <summary>
        /// Condiciones de la venta: 01 Contado, 02 Crédito, 03 Consignación, 04 Apartado, 05 Arrendamiento con opción de compra, 06 Arrendamiento en función financiera, 99 Otros
        /// <remarks>2 caracteres máximo</remarks>
        /// </summary>
        public string CondicionVenta { get => condicionVenta; set => condicionVenta = value; }

        /// <summary>
        /// Plazo del crédito, es obligatorio cuando la venta del producto o prestación del servicio sea a crédito [OPCIONAL]
        /// <remarks>10 caracteres máximo</remarks>
        /// </summary>
        public string PlazoCredito { get => plazoCredito; set => plazoCredito = value; }

        /// <summary>
        /// De 1 a maximo 4 repeticiones
        /// </summary>
        public List<MedioPagoType> LstMedioPago { get => lstMedioPago; set => lstMedioPago = value; }

        /// <summary>
        /// Detalle de la mercancia o servicio prestado.
        /// </summary>
        public string DetalleServicio { get => detalleServicio; set => detalleServicio = value; }
        
    }
}
