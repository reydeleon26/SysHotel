using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SysHotelv1.Models
{
    public class ReservationDetails
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        
        [Required]
        [Display(Name ="Habitacion")]
        public Rooms Rooms {get;set;}
        public int ReservationId { get; set; }
        
        [Required]
        [Display(Name ="Reservacion")]
        public Reservation Reservation { get; set; }
        
        [Required]
        [Display(Name ="Cantidad de Niños")]
        public int ChildQty { get; set; }
        
        [Required]
        [Display(Name ="Cantidad de Adultos")]
        public int AdultQty { get; set; }
        public ICollection<Invoices> Invoices { get; set; }

        }


    }
