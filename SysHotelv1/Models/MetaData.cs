using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SysHotelv1.Models
{
    public class RoomsMetadata
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Id")]
        [Display(Name ="Tipo de Habitacion")]
        [Required(ErrorMessage ="El campo de tipo de habitacion es obligatorio")]
        public RoomType RoomType { get; set; }
        [ForeignKey("Id")]
        [Display(Name = "Tipo de Cama")]
        [Required(ErrorMessage = "El campo de tipo de camas es obligatorio")]
        public BedType BedType { get; set; }
        [Display(Name = "Numero de Habitacion")]
        [Required(ErrorMessage = "El campo de numero de habitacion es obligatorio")]
        [MaxLength(length:10)]
        public string RoomNumber { get; set; }

    }
    public class ClientsMetadata
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Nombres")]
        [Required]
        public string FullName { get; set; }
        [Display(Name = "Apellidos")]
        [Required]
        public string LastName { get; set; }
        [Display(Name = "Correo")]
        public string Email { get; set; }
        [Display(Name = "Pais")]
        public Country Country { get; set; }
        [Display(Name = "Telefono")]
        [Required]
        public string Phone { get; set; }
        public ICollection<Reservation> Reservation { get; set; }
    }
}