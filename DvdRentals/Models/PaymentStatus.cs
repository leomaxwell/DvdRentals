using DvdRentals.Helpers;
using System.ComponentModel.DataAnnotations;

namespace DvdRentals.Models
{
    public class PaymentStatus : BaseModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        //Navigation Properties
        public ICollection<Payment> Payments { get; set; }
    }
}
