using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRLibre.Models
{
    public class Login
    {
        [Required]
        public string userName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string pwd { get; set; }
    }
}