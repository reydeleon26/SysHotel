using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SysHotelv1.Models
{
    public class PricesPerPerson
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

    }
}