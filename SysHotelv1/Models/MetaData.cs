using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SysHotelv1.Models
{

    #region NotationAssign
    [MetadataType(typeof(RoomsMetadata))]
    public partial class Rooms
    {
    }
    #endregion

    #region SetUpOfNotations
    public class RoomsMetadata
    {
        public int Id { get; set; }

        [Display(Name ="Tipo de Habitacion")]
        [Required(ErrorMessage ="El campo de tipo de habitacion es obligatorio")]
        public int RoomTypeId { get; set; }

        [Display(Name = "Tipo de Cama")]
        [Required(ErrorMessage = "El campo de tipo de camas es obligatorio")]
        public int BedTypeId { get; set; }

        [Display(Name = "Numero de Habitacion")]
        [Required(ErrorMessage = "El campo de numero de habitacion es obligatorio")]
        [MaxLength(10)]
        public string RoomNumber { get; set; }

    }
    public class ClientsMetadata
    {
        public int Id { get; set; }

        [Display(Name ="Nombres")]
        [Required]
        public string FullName { get; set; }

        [Display(Name = "Apellidos")]
        [Required]
        public string LastName { get; set; }

        [Required]
        [MinLength(10)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "El correo no es valido")]
        [Display(Name = "Correo")]
        public string Email { get; set; }

        [Display(Name = "Pais")]
        [Required]
        public int IdCountry { get; set; }

        [Display(Name = "Telefono")]
        [DataType(DataType.PhoneNumber)]
        [Required]
        public string Phone { get; set; }

        [Display(Name = "Reservaciones")]
        public ICollection<Reservation> Reservation { get; set; }
    }
    public class CountryMetadata
    {
        [Required]
        [Display(Name="Paises")]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Pais")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Nacionalidad")]
        public string Nationaly { get; set; }
        public ICollection<City> City { get; set; }
        public ICollection<Clients> Clients { get; set; }
    }
    public class BedTypeMetadata
    {
        public int Id { get; set; }
        [Required]
        [MinLength(5,ErrorMessage ="La longitud minima es 5")]
        [Display(Name = "Descripcion")]
        public string Description { get; set; }


        [Required]
        [MinLength(5)]
        [Display(Name = "Precio/Cama")]
        [DataType(DataType.Currency)]
        public decimal PricerPerBed { get; set; }
    }
    public class CityMetadata
    {
        [Display(Name="Ciudades")]
        public int Id { get; set; }
        [Required]
        [StringLength(3,ErrorMessage ="Introduzca un nombre de ciudad valido")]
        public string Name { get; set; }
        [Required]
        public int CountryId { get; set; }
        public Country Country { get; set; }

    }
    public class BookingStatusMetadata
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(10, ErrorMessage ="La longitud maxima de este campo es 10")]
        public string DescriptionStatus { get; set; }
    }
    public class InvoicesMetadata
    {
        public int Id { get; set; }
        [Required]

        public int ReservationDetailsId { get; set; }
        public ReservationDetails ReservationDetails { get; set; }
        [Required]
        [Display(Name ="Precio/Adulto")]
        [DataType(DataType.Currency)]
        public decimal PriceAdult { get; set; }
        [Required]
        [Display(Name = "Precio/Nino")]
        [DataType(DataType.Currency)]
        public decimal PriceChild { get; set; }

        [Required]
        [Display(Name = "Cantidad de Dias")]
        public int DayCount { get; set; }

        [Required]
        [Display(Name = "Descuento por Temporada")]
        public decimal SeasonalDiscount { get; set; }

        [Required]
        [Display(Name = "Total")]
        [DataType(DataType.Currency)]
        public int Total { get; set; }
    }
    public class PersonTypeMetadata
    {
        [Required]
        [Display(Name ="Tipo de Persona")]
        public int Id { get; set; }

        [Required]
        [StringLength(25,ErrorMessage ="Este campo no puede tener mas de 25 caracteres")]
        [Display(Name = "Tipo de Personas")]
        public string Description { get; set; }

        [Display(Name = "Precio")]
        [Range(0,Double.MaxValue)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

    }
    public class ReservationMetadata
    {
        [Display(Name = "Id Reservacion")]
        public int Id { get; set; }
        [Display(Name = "Cliente")]
        [Required]
        public int ClientId { get; set; }
        public Clients Clients { get; set; }
        [Required]
        [Display(Name = "Cantidad de Habitaciones")]
        [Range(0, Double.MaxValue)]
        public string RoomQty { get; set; }
        [Required]
        public bool AllInclusive { get; set; }
        [DataType(DataType.Date)]
        [Required]
        [Display(Name="CheckIn")]
        public DateTime CheckIn { get; set; }

        [DataType(DataType.Date)]
        [Required]
        [Display(Name = "CheckOut")]
        public DateTime CheckOut { get; set; }

        [Required]
        [Display(Name = "CheckIn")]
        [Range(0,int.MaxValue)]
        public int DaysNumber { get; set; }

        [Required]
        [Display(Name ="Estado de la Reservacion")]
        public int BookingStatusId { get; set; }
        public BookingStatus BookingStatus { get; set; }
        public ICollection<ReservationDetails> ReservationDetails { get; set; }


    }




    #endregion

}