using DvdRentals.Helpers;
using System.ComponentModel.DataAnnotations;

namespace DvdRentals.Models
{
    public class PaymentType : BaseModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        //Navigation Property
        public ICollection<Payment> Payments{ get; set; }
    }
}
