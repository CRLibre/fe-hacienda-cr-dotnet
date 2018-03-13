using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CRLibre.FE.Entidades;

namespace CRLibre.FE.LogicaNegocio
{
    public class CertificadoLogicaNegocio
    {
        private void prueba() {

            FacturaElectronica FE = new FacturaElectronica();

            FE.Emisor = new EmisorType();

            FE.Receptor = new ReceptorType();

            FE.CondicionVenta = FacturaElectronicaCondicionVenta.Arrendamiento_con_opción_de_compra;
            FE.Emisor.Identificacion = new IdentificacionType();
            FE.Emisor.Identificacion.Tipo = IdentificacionTypeTipo.Cédula_Física;
            FE.Emisor.Identificacion.Numero = "205930122";
            

            FE.Emisor.Nombre = "DESARROLLO SISTEMAS.NET";



        }
    }
}
