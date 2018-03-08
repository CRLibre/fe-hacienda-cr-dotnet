using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRLibre.FE.Entidades
{
    /// <summary>
    /// Detalle de la mercancia o servicio prestado.
    /// De 1 a maximo 1000 repeticiones
    /// </summary>
    public class LineaDetalle
    {
        Int32 numeroLinea;
        CodigoType codigo;
        Decimal cantidad;
        UnidadMedidaType UnidadMedida;
        String UnidadMedidaComercial;
        String detalle;
        DecimalDineroType precioUnitario;
        DecimalDineroType montoTotal;
        DecimalDineroType montoDescuento;
        String naturalezaDescuento;
        DecimalDineroType subTotal;
        DecimalDineroType impuesto;


        /// <summary>
        /// Número de línea del detalle
        /// <remarks>Número entero positivo</remarks>
        /// </summary>
        public int NumeroLinea { get => numeroLinea; set => numeroLinea = value; }

        /// <summary>
        /// 
        ///  <remarks>De 1 a 5 repeticiones</remarks>
        /// </summary>
        public CodigoType Codigo { get => codigo; set => codigo = value; }

        /// <summary>
        /// Cantidad
        /// <remarks> 16 caracteres numeros maximos y 3 decimales maximos. Se esta indicando un redondeo de 3 decimaes, pero no se esta validando la cantidad de 
        /// caracteres en el valor numerico, ya que deberia superar una cifra de 16 caracteres, por ejemplo: 4 300 000 785 000 540: Cuatro mil trescientos billones setecientos ochenta y cinco millones quinientos cuarenta.</remarks>
        /// 
        /// </summary>
        public decimal Cantidad {
            get => Math.Round(cantidad, 3);
            set => cantidad = value; }

        /// <summary>
        /// Unidad de medida
        /// </summary>
        public UnidadMedidaType UnidadMedida1 { get => UnidadMedida; set => UnidadMedida = value; }

        /// <summary>
        /// Unidad de medida comercial [OPCIONAL]
        /// <remarks>20 caracteres máximo</remarks>
        /// </summary>
        public string UnidadMedidaComercial1 { get => UnidadMedidaComercial; set => UnidadMedidaComercial = value; }

        /// <summary>
        /// Detalle de la mercancia transferida o servicio prestado
        /// <remarks>160 caracteres máximo</remarks>
        /// </summary>
        public string Detalle { get => detalle; set => detalle = value; }

        /// <summary>
        /// Precio Unitario
        /// </summary>
        public DecimalDineroType PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }

        /// <summary>
        /// Se obtiene de multiplicar el campo cantidad por el campo precio unitario 
        /// </summary>
        public DecimalDineroType MontoTotal { get => montoTotal; set => montoTotal = value; }

        /// <summary>
        /// Monto de descuento concedido, el cual es obligatorio si existe descuento [OPCIONAL]
        /// </summary>
        public DecimalDineroType MontoDescuento { get => montoDescuento; set => montoDescuento = value; }

        /// <summary>
        /// Naturaleza del descuento, que es obligatorio si existe descuento [OPCIONAL]
        /// <remarks>80 caracteres máximo</remarks>
        /// </summary>
        public string NaturalezaDescuento { get => naturalezaDescuento; set => naturalezaDescuento = value; }

        /// <summary>
        /// Se obtiene de la resta del campo monto total menos monto de descuento concedido
        /// </summary>
        public DecimalDineroType SubTotal { get => subTotal; set => subTotal = value; }

        /// <summary>
        /// Cuando el producto o servicio este gravado con algún impuesto se debe indicar cada uno de ellos.
        /// </summary>
        public DecimalDineroType Impuesto { get => impuesto; set => impuesto = value; }
    }
}
