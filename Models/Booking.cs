using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HireTrailer.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ClientId { get; set; }
        public string TrailerRegistration { get; set; }
    }
}