using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Person_Registro.Models
{
    public class Personas
    {
        [Key]
        public int PersonaId { get; set; }

        [Required(ErrorMessage ="Este Campo es Obligatorio!!!")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Este Campo es Obligatorio!!!")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Este Campo es Obligatorio!!!")]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "Este Campo es Obligatorio!!!")]
        public string Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
