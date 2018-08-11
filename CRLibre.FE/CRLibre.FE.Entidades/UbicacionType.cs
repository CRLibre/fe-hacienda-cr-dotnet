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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://tribunet.hacienda.go.cr/docs/esquemas/2017/v4.2/facturaElectronica")]
    public class UbicacionType
    {

        #region Variables

        private string provinciaField;

        private string cantonField;

        private string distritoField;

        private string barrioField;

        private string otrasSenasField;

        #endregion

        #region Metodos

        /// <summary>
        /// Provincia | un digito
        ///  | [REQUERIDO]
        /// </summary>
        public string Provincia
        {
            get
            {
                return this.provinciaField;
            }
            set
            {
                this.provinciaField = value;
            }
        }

        /// <summary>
        /// Canton | dos digitos
        ///  | [REQUERIDO]
        /// </summary>
        public string Canton
        {
            get
            {
                return this.cantonField;
            }
            set
            {
                this.cantonField = value;
            }
        }

        /// <summary>
        /// Distrito | tres digitos
        ///  | [REQUERIDO]
        /// </summary>
        public string Distrito
        {
            get
            {
                return this.distritoField;
            }
            set
            {
                this.distritoField = value;
            }
        }

        /// <summary>
        /// Barrio | dos digitos
        ///  | [OPCIONAL]
        /// </summary>
        public string Barrio
        {
            get
            {
                return this.barrioField;
            }
            set
            {
                this.barrioField = value;
            }
        }

        /// <summary>
        /// Otras señas | 160 caracteres máximo
        ///  | [REQUERIDO]
        /// </summary>
        public string OtrasSenas
        {
            get
            {
                return this.otrasSenasField;
            }
            set
            {
                this.otrasSenasField = value;
            }
        }

        #endregion
    }
}
