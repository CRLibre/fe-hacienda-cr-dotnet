using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRLibre.FE.Entidades
{
    /// <summary>
    /// Corresponde al medio de pago empleado: 01 Efectivo, 02 Tarjeta, 03 Cheque, 04 Transferencia - depósito bancario, 05 - Recaudado por terceros, 99 Otros
    /// <remarks>2 caracteres máximo [DE 1 A 4 REPETICIONES]</remarks>
    /// </summary>
    public class MedioPagoType
    {
        String medioPago;

        /// <summary>
        /// Corresponde al medio de pago empleado: 01 Efectivo, 02 Tarjeta, 03 Cheque, 04 Transferencia - depósito bancario, 05 - Recaudado por terceros, 99 Otros
        /// </summary>
        public string MedioPago { get => medioPago; set => medioPago = value; }
    }
}
