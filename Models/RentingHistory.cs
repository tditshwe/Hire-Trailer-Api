using System;

namespace HireTrailer.Models
{
    public class RentingHistory
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ClientId { get; set; }
        public string TrailerRegistration { get; set; }
    }
}