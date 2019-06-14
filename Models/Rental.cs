using System;

namespace HireTrailer.Models
{
    public class Rental
    {
        public int Id { get; set; }
        public DateTime DateRented { get; set; }
        public int ClientId { get; set; }
        public string TrailerRegistration { get; set; }
    }
}