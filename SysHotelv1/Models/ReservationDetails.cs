using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SysHotelv1.Models
{
    public class ReservationDetails
    {
        public int Id { get; set; }
        public Rooms Rooms {get;set;}
        public Reservation Reservation { get; set; }
        public int ChildQty { get; set; }
        public int AdultQty { get; set; }


    }
}