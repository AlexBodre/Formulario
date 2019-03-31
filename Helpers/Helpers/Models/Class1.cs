using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Helpers.Models
{
    public class Class1
    {
        [Required]
        public string cedula { get; set; }
        [Required]
        public string nombre { get; set; }
        [Required]
        public string apellido { get; set; }
        [Range(15, double.MaxValue, ErrorMessage = "Debes tener al menos 15 años")]
        public int edad { get; set; }
        public string telefono { get; set; }
        [EmailAddress]
        public string correo { get; set; }
        public string genero { get; set; }
        public string estadoCivil { get; set; }
        public string pasatiempos { get; set; }
    }
}