using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HoteleriaMascotas.Models
{
    public class MascotaM
    {
        public int idMascota { get; set; }

        [Required]
        [Range(1, 60,ErrorMessage ="ingrese numeros desde 1 a 60")]
        [Display(Name = "idCliente")]
        public int idCliente { get; set; }

       
        [Required]
        [StringLength(15)]
        [Display(Name = "Nombre")]
        public String Nombre { get; set; }
        
        [Required]
        [Range(25, 60, ErrorMessage = "Age must be between 25 and 60")]
        [Display(Name = "Edad")]
        public float Edad { get; set; }

        
        [Required]
        [Range(1, 60, ErrorMessage = "ingrese numeros desde 1 a 60")]
        [Display(Name = "Chip")]
        public int Chip { get; set; }
        
        [Required]
        [StringLength(15)]
        [Display(Name = "Raza")]
        public String Raza { get; set; }
        
        [Required]
        [StringLength(15)]
        [Display(Name = "TipoDeAnimal")]
        public String TipoDeAnimal { get; set; }

        
        [Required]
        [StringLength(15)]
        [Display(Name = "Personalidad")]
        public String Personalidad { get; set; }
    }
}

