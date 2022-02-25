using DvdRentals.Helpers;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DvdRentals.Models
{
    public class Rental : BaseModel
    {
        public int Id { get; set; }
        
        [ForeignKey(nameof(Models.Employee))]
        public int ServedById { get; set; }

        [ForeignKey(nameof(Models.Customer))]
        public int CustomerId { get; set; }

        [ForeignKey(nameof(Models.Payment))]
        public int PaymentId { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [ForeignKey(nameof(Models.RentalStatus))]
        public int StatusId { get; set; }

        //Navigation Properties
        public Employee Employee { get; set; }
        public Customer Customer { get; set; }
        public Payment Payment { get; set; }
        public RentalStatus RentalStatus { get; set; }
    }
}
