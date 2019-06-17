using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HireTrailer.Models
{
    public class RentalRetrieve
    {
        public string Client { get; set; }
        public string TraileRegistration { get; set; }
        public DateTime DateRented { get; set; }
    }

    public class Rental
    {
        [ForeignKey("Client")]
        public int Id { get; set; }
        public DateTime DateRented { get; set; }
        public int ClientId { get; set; }

        [ForeignKey("Trailer")]
        public string TraileRegistration { get; set; }

        public virtual Client Client { get; set; }
        public virtual Trailer Trailer { get; set; }
    }
}