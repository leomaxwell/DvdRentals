using DvdRentals.Helpers;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DvdRentals.Models
{
    public class Store : BaseModel
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

        [Required]
        [ForeignKey(nameof(Models.Distributor))]
        public int DistributorId { get; set; }

        //Navigation Property
        public Distributor Distributor { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
