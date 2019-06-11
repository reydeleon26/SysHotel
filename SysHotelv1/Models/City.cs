using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SysHotelv1.Models
{
    public class City
    {
        public int Id { get; set; }
        
        [Required]
	    [Display(Name ="Ciudad")]
        public string Name { get; set; }
        public int CountryId { get; set; }
        
        [Required]
	    [Display(Name ="Pais")]
        public Country Country { get; set; }

    }
}
