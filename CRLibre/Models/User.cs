using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace CRLibre.Models
{
    public class User
    {
        public int idUser { get; set; }
        [DisplayName("Nombre")]
        public string fullName { get; set; }
        [DisplayName("Usuario")]
        public string userName { get; set; }
        [DisplayName("Correo")]
        public string email { get; set; }
        [DisplayName("Acerca")]
        public string about { get; set; }
        [DisplayName("País")]
        public string country { get; set; }
        [DisplayName("Estado")]
        public int status { get; set; }
        public string timestamp { get; set; }
        [DisplayName("Ultimo ingreso")]
        public string lastAccess { get; set; }
        [DisplayName("Contraseña")]
        public string pwd { get; set; }
        public string avatar { get; set; }
        public string settings { get; set; }
    }
}