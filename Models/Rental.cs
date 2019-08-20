using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HireTrailerApi.Models
{
    public class RentalRetrieve
    {
        public string Client { get; set; }
        public string TraileRegistration { get; set; }
        public DateTime DateRented { get; set; }
    }

    public class Rental
    {
        [Key]
        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public DateTime DateRented { get; set; }

        [ForeignKey("Trailer")]
        public string TraileRegistration { get; set; }

        public virtual Client Client { get; set; }
        public virtual Trailer Trailer { get; set; }
    }
}