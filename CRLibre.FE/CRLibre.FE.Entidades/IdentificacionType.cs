using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRLibre.FE.Entidades
{
    /// <summary>
    /// Tipo de identificación
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2558.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://tribunet.hacienda.go.cr/docs/esquemas/2017/v4.2/facturaElectronica")]
    public class IdentificacionType
    {
        #region Variables

        private IdentificacionTypeTipo tipoField;

        private string numeroField;

        #endregion

        #region Metodos

        /// <summary>
        /// Tipo de identificación
        ///  | [REQUERIDO]
        /// </summary>
        public IdentificacionTypeTipo Tipo
        {
            get
            {
                return this.tipoField;
            }
            set
            {
                this.tipoField = value;
            }
        }

        /// <summary>
        /// Número de identificación, el contribuyente debe estar inscrito ante la Administración Tributaria | 
        /// Entre 9 a 12 caracteres
        ///  | [REQUERIDO]
        /// </summary>
        public string Numero
        {
            get
            {
                return this.numeroField.Substring(0,12);
            }
            set
            {
                this.numeroField = value;
            }
        }

        #endregion
    }

    /// <summary>
    /// Tipo de identificación
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2558.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "https://tribunet.hacienda.go.cr/docs/esquemas/2017/v4.2/facturaElectronica")]
    public enum IdentificacionTypeTipo
    {
        /// <summary>
        /// Cédula Física
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Cédula_Física,

        /// <summary>
        /// Cédula Jurídica
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Cédula_Jurídica,

        /// <summary>
        /// DIMEX
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("03")]
        DIMEX,

        /// <summary>
        /// NITE
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("04")]
        NITE,
    }
}
