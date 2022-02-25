using DvdRentals.Helpers;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DvdRentals.Models
{
    public class Payment : BaseModel
    {
        public int Id { get; set; }

        [Required]
        [ForeignKey(nameof(Models.Rental))]
        public int RentalId { get; set; }

        [ForeignKey(nameof(Employee))]
        public int ReceivedById { get; set; }

        [ForeignKey(nameof(Models.PaymentType))]
        public int TypeId { get; set; }

        [MaxLength(500)]
        public string Note { get; set; }

        [Required]
        [Column(TypeName = "Decimal(18,2)")]
        public decimal Amount { get; set; }

        [Required]
        [Column(TypeName = "Date")]
        public DateTime Date { get; set; }

        [Required]
        [ForeignKey(nameof(Models.PaymentStatus))]
        public int StatusId { get; set; }

        //Navigation Properties
        public Rental Rental { get; set; }
        public Employee Cashier { get; set; }
        public PaymentType PaymentType { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
    }
}
