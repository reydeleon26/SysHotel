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
        public DbSet<Invoices> Invoices { get; set; }
        
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
            modelBuilder.Entity<City>().HasRequired<Country>(s => s.Country).WithMany(t => t.City).HasForeignKey<int>(s => s.CountryId);
            modelBuilder.Entity<ReservationDetails>().HasRequired<Reservation>(s => s.Reservation).WithMany(t => t.ReservationDetails).HasForeignKey<int>(s => s.ReservationId);
            modelBuilder.Entity<ReservationDetails>().HasRequired<Rooms>(x => x.Rooms).WithMany(a => a.ReservationDetails).HasForeignKey<int>(s=> s.RoomId);
            modelBuilder.Entity<Rooms>().HasRequired<RoomType>(X=> X.RoomType).WithMany(x=> x.Rooms).HasForeignKey<int>(s=>s.RoomTypeId);
            modelBuilder.Entity<Rooms>().HasRequired<BedType>(x => x.BedType).WithMany(x => x.Rooms).HasForeignKey<int>(s => s.BedTypeId);
            modelBuilder.Entity<Reservation>().HasRequired<BookingStatus>(x => x.BookingStatus).WithMany(x => x.Reservations).HasForeignKey<int>(s => s.BookingStatusId);
            modelBuilder.Entity<Reservation>().HasRequired<Clients>(x => x.Clients).WithMany(x => x.Reservation).HasForeignKey<int>(s => s.ClientId);
            #endregion
            base.OnModelCreating(modelBuilder);
        }
    }
}