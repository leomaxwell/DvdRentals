using DvdRentals.Helpers;
using System.ComponentModel.DataAnnotations;

namespace DvdRentals.Models
{
    public class Movie : BaseModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Title { get; set; }

        [Required]
        [MaxLength(150)]
        public string DirectorName { get; set; }

        [Required]
        [MaxLength(500)]
        public string Description { get; set; }

        [MaxLength(500)]
        public string MajorStar { get; set; }

        [Required]
        public int Rating { get; set; }

        //Navigation Properties
        public ICollection<Dvd> Dvds { get; set; }
    }
}
