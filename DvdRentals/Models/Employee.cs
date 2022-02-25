using DvdRentals.Helpers;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DvdRentals.Models
{
    public class Employee : BaseModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string EmployeeNo { get; set; }

        [ForeignKey(nameof(Models.Store))]
        public int StoreId { get; set; }

        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        [ForeignKey(nameof(Models.Employee))]
        public int? SupervisorId { get; set; }

        [Required]
        [MaxLength(500)]
        public string Address { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [Required]
        [MaxLength(20)]
        public string PhoneNo { get; set; }

        [MaxLength(50)]
        public string SSN { get; set; }

        [Required]
        public DateTime DateHired { get; set; }

        //Navigation Properties
        public Store Store { get; set; }
        public Employee Supervisor { get; set; }

        public ICollection<Employee> Employees { get; set; }
        public ICollection<Payment> PaymentsReceived { get; set; }
        public ICollection<Rental> RentalsServed { get; set; }
    }
}
