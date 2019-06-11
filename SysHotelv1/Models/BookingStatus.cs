using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SysHotelv1.Models
{
    public class BookingStatus
    {
        public int Id { get; set; }
        
        [Required]
	    [Display(Name ="Estatus")]
        public string DescriptionStatus { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}
