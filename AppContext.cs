using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using HireTrailer.Models;

namespace HireTrailer
{
    public class AppContext: DbContext
    {
        public AppContext() : base("TrailerHireContext")
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Rental> Rentals  { get; set; }
        public DbSet<Trailer> Trailers  { get; set; }
        public DbSet<Booking> Bookings  { get; set; }
        public DbSet<RentingHistory> RentingHistory  { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}