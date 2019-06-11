using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SysHotelv1.Models
{
    public class BedType
    {
       public int Id { get; set; }
        
       [Required]
	   [Display(Name ="Tipo de Habitacion")]
       public string Description { get; set; }
        
       [Display(Name = "Precio por Cama")]
       [DataType(DataType.Currency)]
       public decimal PricerPerBed { get; set; }
        
       public ICollection<Rooms> Rooms { get; set; }
       public ICollection<ReservationDetails> ReservationDetails { get; set; }


    }
}
