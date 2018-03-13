using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

//Leer archivo p12 y firmar: https://gist.github.com/srikanthps/3488237#file-program-cs-L22

namespace CRLibre.FE.Presentacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionarCertificado_Click(object sender, EventArgs e)
        {
            try
            {
                // Se Declaras un Objeto de Tipo OpenFileDialog
                OpenFileDialog dialogo = new OpenFileDialog();

                //Se define la ruta donde se leerá el archivo, el tipo de extensión necesaria
                dialogo.InitialDirectory = "c:\\";
                dialogo.Filter = "Certificado digital (*.p12)|*.p12|All files (*.*)|*.*";

                //Se indica qeu por default, seleccione la primera opcion del combobox
                dialogo.FilterIndex = 1;
                dialogo.RestoreDirectory = true;

                //Invocamos el mostrar el cuadro de seleccion de archivo
                if (dialogo.ShowDialog() == DialogResult.OK)
                {
                    //solo si se selecciono un archivo y se oprime OK obtenemos la ruta y se coloca en el textbox
                    txtUbicacionCertificadoDigital.Text = dialogo.FileName;

                    LeerFirmaDigital();
                }
                else
                {
                    //Caso contrario, se limpia los texbox y se inicia el proceso nuevamnete
                    txtIdentificacionContribuyente.Text = String.Empty;
                    txtPasswordContibuynete.Text = String.Empty;
                }

            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LeerFirmaDigital()
        {
            if (txtIdentificacionContribuyente.Text.Trim() == String.Empty) throw new Exception("Debe indicar el número de cedula");

            if (txtPasswordContibuynete.Text.Trim() == String.Empty) throw new Exception("Debe indicar la contraseña del certifcicado");

            X509Certificate2 uidCert = new X509Certificate2(txtUbicacionCertificadoDigital.Text, txtPasswordContibuynete.Text, X509KeyStorageFlags.DefaultKeySet);

            //Datos del certificado
            lblDatosCertificado.Text = "Datos del certificado:" + "\n\r" +
            "Identificador: " + uidCert.FriendlyName + "\n\r" +
            "Número serie: " + uidCert.GetSerialNumberString() + "\n\r" +
            "Hash: " + uidCert.GetCertHashString() + "\n\r" +
            "Fecha efectiva: " + uidCert.GetEffectiveDateString() + "\n\r" +
            "Fecha expiración: " + uidCert.GetExpirationDateString() + "\n\r" +
            "Formato: " + uidCert.GetFormat() + "\n\r" +
            "Numero de Hash" + uidCert.GetHashCode().ToString() + "\n\r" +
            "Entidad certificadora: " + uidCert.GetIssuerName() + "\n\r" +
            "Información del algoritmo: " + uidCert.GetKeyAlgorithm() + "\n\r" +
            "Parametros del algoritmo: " + uidCert.GetKeyAlgorithmParametersString() + "\n\r" +
            "Nombre Principal: " + uidCert.GetName() + "\n\r" +
            "Nombres del emisor: " + uidCert.GetNameInfo(X509NameType.UrlName,true) + "\n\r" + 
            "Llave publica: " + uidCert.GetPublicKeyString() + "\n\r" +
            //"Todos los datos: " + uidCert.GetRawCertDataString() + "\n\r" +
            "Nombre de entidad certificadora: " + uidCert.Issuer + "\n\r" +
            "Nombre completo del emisor: " + uidCert.IssuerName +"\n\r" +
            "Fecha certificado no valido: " + uidCert.NotAfter + "\n\r" +
            "Fecha Certificado es valido:" + uidCert.NotBefore + "\n\r" +
            "Número de serie: " + uidCert.SerialNumber + "\n\r" +
            "Nombre del sujeto del certificado: " + uidCert.Subject + "\n\r" +
            "Huella digital del certificado: " + uidCert.Thumbprint + "\n\r" +
            "Versión: " + uidCert.Version + "\n\r" +
            "";
            



            MessageBox.Show("El certificado fue leido con exito");
        }
    }
}
