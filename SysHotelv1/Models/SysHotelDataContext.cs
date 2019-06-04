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
        public DbSet<PersonType> PricesPerPeople { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<ReservationDetails> ReservationDetails { get; set; }
        public DbSet<Rooms> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            #region PrimaryKeys
            modelBuilder.Entity<ReservationDetails>().HasKey(p => new { p.Id });
            modelBuilder.Entity<Reservation>().HasKey(p => new { p.Id });
            modelBuilder.Entity<Rooms>().HasKey(p => new { p.Id });
            modelBuilder.Entity<Clients>().HasKey(p => new { p.Id });
            modelBuilder.Entity<City>().HasKey(p => new { p.Id });
            modelBuilder.Entity<BedType>().HasKey(p => new { p.Id });
            modelBuilder.Entity<BookingStatus>().HasKey(p => new { p.Id });
            modelBuilder.Entity<PersonType>().HasKey(p => new { p.Id });
            modelBuilder.Entity<RoomType>().HasKey(p => new { p.Id });
            modelBuilder.Entity<Country>().HasKey(p => new { p.Id });
            #endregion

            #region ForeignKeys
            modelBuilder.Entity<Reservation>();
            #endregion

            #region HasRequired
            modelBuilder.Entity<City>().HasRequired<Country>(s => s.Country).WithMany(t => t.City).HasForeignKey<int>(s => s.CountryId);
            modelBuilder.Entity<ReservationDetails>().HasRequired<Reservation>(s => s.Reservation).WithMany(t => t.ReservationDetails).HasForeignKey<int>(s => s.ReservationId);
            modelBuilder.Entity<ReservationDetails>().HasRequired(x => x.Rooms);
            modelBuilder.Entity<Rooms>().HasRequired(x => x.RoomType);
            modelBuilder.Entity<Rooms>().HasRequired(x => x.BedType);
            modelBuilder.Entity<Reservation>().HasRequired(x => x.BookingStatus);
            modelBuilder.Entity<Reservation>().HasRequired(x => x.Clients);
            #endregion
            base.OnModelCreating(modelBuilder);
        }
    }
}