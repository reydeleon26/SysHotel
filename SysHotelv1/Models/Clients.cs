using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SysHotelv1.Models
{
    public class Clients
    {
        public int Id { get; set; }
        
        [Required]
	    [Display(Name ="Nombres")]
        public string FullName { get; set; }
                
        [Required]
	    [Display(Name ="Apellidos")]
        public string LastName { get; set; }
        
        [Required]
	    [Display(Name ="Documento de Identificacion")]
        public string Identification { get; set; }
        
        [Display(Name = "Correo Electronico")]
        [MinLength(10)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        
        public int IdCountry { get; set; }
        
        [Required]
	    [Display(Name ="Pais")]
        public Country Country { get; set; }
        
        [Display(Name = "Telefono")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
       
        public ICollection<Reservation> Reservation { get; set; }

        
    }
}
