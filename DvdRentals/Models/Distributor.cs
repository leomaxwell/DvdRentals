using DvdRentals.Helpers;
using System.ComponentModel.DataAnnotations;

namespace DvdRentals.Models
{
    public class Distributor : BaseModel
    {
        public int Id { get; set; }
        
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        [Required]
        [MaxLength(500)]
        public string Address { get; set; }

        [Required]
        [MaxLength(20)]
        public string PhoneNo { get; set; }

        //Navigation Property
        public ICollection<Movie> Movies { get; set; }
        public ICollection<Store> Stores { get; set; }
    }
}
