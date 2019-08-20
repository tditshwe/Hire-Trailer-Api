using System.ComponentModel.DataAnnotations;

namespace HireTrailerApi.Models
{
    public class Trailer
    {
        [Key]
        public string Registration { get; set; }
        public bool IsRented { get; set; }
        public bool IsBooked { get; set; }
    }
}