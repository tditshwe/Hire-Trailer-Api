using Microsoft.EntityFrameworkCore;
using HireTrailerApi.Models;

namespace HireTrailerApi
{
    public class HireTrailerContext: DbContext
    {
        public DbSet<Client> Client { get; set; }
        public DbSet<Trailer> Trailer  { get; set; }
        public DbSet<Rental> Rental  { get; set; }
        public DbSet<Booking> Booking  { get; set; }
        public DbSet<RentingHistory> RentingHistory  { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=CEN_KGOTHATSOD1\SQLEXPRESS;Initial Catalog=TrailerHire;Integrated Security=True;MultipleActiveResultSets=True");
        }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Client>().HasData( new Client
            {
                Name = "Kutlwano",
                Email = "ktl@domain.com",
                Lastname = "Motho",
                IsRenting = false,
                DateCreated = DateTime.Now,
                LastRented = new DateTime(2000, 1, 1)
            });
             
        }*/
    }
}