using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SysHotelv1.Models
{
    public partial class Rooms
    {
        public int Id { get; set; }
        
        [Required]
        [Display(Name ="Tipo de Cama")]
        public RoomType RoomType { get; set; }
        public int RoomTypeId { get; set; }
        
        [Required]
        [Display(Name ="Tipo de Cama")]
        public BedType BedType { get; set; }
        public int BedTypeId { get; set; }
        
        [Required]
        [Display(Name ="Numero de Habitacion")]
        public string RoomNumber { get; set; }
        public ICollection<ReservationDetails> ReservationDetails { get; set; }


    }
}
