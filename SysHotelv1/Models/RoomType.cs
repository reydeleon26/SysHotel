using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SysHotelv1.Models
{
    public class RoomType
    {

        public int Id { get; set; }
        
        [Required]
        [Display(Name ="Tipo de Habitacion")]
        public string Description { get; set; }
        
        [Required]
        [Display(Name ="Precio por Habitacion")]
        public decimal PricePerRoom { get; set; }
        
        public ICollection <Rooms> Rooms { get; set; }
        public ICollection<ReservationDetails> ReservationDetails { get; set; }
    }
}
