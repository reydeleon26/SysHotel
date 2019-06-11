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
        
        [Required]
        [Display(Name ="Detalle de la Reservacion")]
        public ReservationDetails ReservationDetails { get; set; }
        
        [Required]
        [Display(Name ="Precio por Adulto")]
        public decimal PriceAdult { get; set; }
        
        [Required]
        [Display(Name ="Precio por Niño")]
        public decimal PriceChild { get; set; }
        
        [Required]
        [Display(Name ="Cantidad de Dias")]
        public int DayCount { get; set; }
        
        [Required]
        [Display(Name ="Descuento de Temporada")]
        public decimal SeasonalDiscount { get; set; }
        public int Total { get; set; }

    }
}
