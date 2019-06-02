using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SysHotelv1.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nationaly { get; set; }
        public ICollection<City> City { get; set; }

    }
}