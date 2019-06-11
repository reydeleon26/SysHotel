using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SysHotelv1.Models
{
    public class Country
    {
        public int Id { get; set; }
        
        [Required]
        [Display(Name ="Pais")]
        public string Name { get; set; }
        
        [Required]
        [Display(Name ="Nacionalidad")]
        public string Nationaly { get; set; }
        
        public ICollection<City> City { get; set; }
        public ICollection<Clients> Clients { get; set; }

    }
}
