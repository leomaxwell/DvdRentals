using DvdRentals.Helpers;
using System.ComponentModel.DataAnnotations;

namespace DvdRentals.Models
{
    public class Customer : BaseModel
    {
        public int Id { get; set; }
        
        [Required]
        [MaxLength(20)]
        public string CustomerNo { get; set; }

        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Address { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [Required]
        [MaxLength(20)]
        public string Phone { get; set; }

        //Navigation Properties
        public ICollection<Rental> Rentals { get; set; }
    }
}
