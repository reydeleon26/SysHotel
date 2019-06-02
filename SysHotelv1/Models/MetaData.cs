using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SysHotelv1.Models
{
    public class MetaData
    {

    }

    public class RoomsMetadata
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Id")]
        [Display(Name ="Tipo de Habitacion")]
        public RoomType RoomType { get; set; }
        [ForeignKey("Id")]
        public BedType BedType { get; set; }
        public string RoomNumber { get; set; }

    }
}