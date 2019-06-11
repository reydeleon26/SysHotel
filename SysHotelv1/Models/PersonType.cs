using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SysHotelv1.Models
{
    public class PersonType
    {
        public int Id { get; set; }
        
        [Required]
        [Display(Name ="Tipo de Persona")]
        public string Description { get; set; }
        
        [Required]
        [Display(Name ="Precio por Persona")]
        public decimal Price { get; set; }

    }
}
