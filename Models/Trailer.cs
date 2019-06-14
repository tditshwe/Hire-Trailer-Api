using System.ComponentModel.DataAnnotations;

namespace HireTrailer.Models
{
    public class Trailer
    {
        [Key]
        public string Registration { get; set; }
        public bool IsHired { get; set; }
        public bool IsBooked { get; set; }
    }
}