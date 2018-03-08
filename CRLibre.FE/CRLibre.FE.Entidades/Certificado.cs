using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRLibre.FE.Entidades
{
    public class Certificado
    {
        String usuario;
        String password;
        Byte[] archivoPFX;

        public byte[] ArchivoPFX {
            get => archivoPFX;
            set => archivoPFX = value;
        }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }
    }
}
