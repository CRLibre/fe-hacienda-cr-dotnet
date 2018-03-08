using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRLibre.FE.Entidades
{
    public class ExoneracionType
    {
        String tipoDocumento;
        String numeroDocumento;
        String nombreInstitucion;
        DateTime fechaEmision;
        DecimalDineroType montoImpuesto;
        Int32 porcentajeCompra;

        /// <summary>
        /// Tipo de documento de exoneración o autorización. 
        /// 01 Compras Autorizadas, 
        /// 02 Ventas exentas a diplomáticos, 
        /// 03 Orden de compra (instituciones públicas y otros organismos), 
        /// 04 Exenciones Dirección General de Hacienda, 
        /// 05 Zonas Francas, 
        /// 99 Otros
        /// <remarks>2 caracteres máximo</remarks>
        /// </summary>
        public string TipoDocumento { get => tipoDocumento; set => tipoDocumento = value; }

        /// <summary>
        /// Número de documento de exoneración o autorización
        /// <remarks>17 caracteres máximo</remarks>
        /// </summary>
        public string NumeroDocumento { get => numeroDocumento; set => numeroDocumento = value; }

        /// <summary>
        /// Nombre de la institución o dependencia que emitió la exoneración
        /// <remarks>100 caracteres máximo</remarks>
        /// </summary>
        public string NombreInstitucion { get => nombreInstitucion; set => nombreInstitucion = value; }

        /// <summary>
        /// Fecha y hora de la emisión del documento de exoneración o autorización.
        /// </summary>
        public DateTime FechaEmision { get => fechaEmision; set => fechaEmision = value; }

        /// <summary>
        /// Monto del impuesto exonerado o autorizado sin impuestos
        /// </summary>
        public DecimalDineroType MontoImpuesto { get => montoImpuesto; set => montoImpuesto = value; }

        /// <summary>
        /// Porcentaje de la compra autorizada o exonerada
        ///  <remarks>3 caracteres máximo</remarks>
        /// </summary>
        public int PorcentajeCompra { get => porcentajeCompra; set => porcentajeCompra = value; }
    }
}
