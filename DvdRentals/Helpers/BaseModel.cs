using System.ComponentModel.DataAnnotations;

namespace DvdRentals.Helpers
{
    public class BaseModel
    {
        [MaxLength(450)]
        public string CreatedBy { get; set; }

        [Required]        
        public DateTime CreatedAt { get; set; }

        [MaxLength(450)]
        public string ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
