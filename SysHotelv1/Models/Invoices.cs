using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SysHotelv1.Models
{
    public class Invoices
    {
        public int Id { get; set; }
        public int ReservationDetailsId { get; set; }
        public decimal PriceAdult { get; set; }
        public decimal PriceChild { get; set; }
        public int DayCount { get; set; }
        public decimal SeasonalDiscount { get; set; }
        public int Total { get; set; }

    }
}