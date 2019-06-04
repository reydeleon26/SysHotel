using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SysHotelv1.Models
{
    public class SysHotelDataContext : DbContext
    {
        public SysHotelDataContext() : base("name=SysHotelDataContext") { }

        public DbSet<BedType> BedType { get; set; }
        public DbSet<BookingStatus> BookingStatuses { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Clients> Clients {get;set;}
        public DbSet<Country> Countries { get; set; }
        public DbSet<PricesPerPerson> PricesPerPeople { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<ReservationDetails> ReservationDetails { get; set; }
        public DbSet<Rooms> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasRequired(x => x.Country);
            modelBuilder.Entity<Country>().HasRequired(x => Cities);
            modelBuilder.Entity<ReservationDetails>().HasRequired(x => x.Reservation);
            modelBuilder.Entity<ReservationDetails>().HasRequired(x => x.Rooms);
            modelBuilder.Entity<Rooms>().HasRequired(x => x.RoomType);
            modelBuilder.Entity<Rooms>().HasRequired(x => x.BedType);
            modelBuilder.Entity<Reservation>().HasRequired(x => x.BookingStatus);
            modelBuilder.Entity<Reservation>().HasRequired(x => x.Clients);
            base.OnModelCreating(modelBuilder);
        }
    }
}