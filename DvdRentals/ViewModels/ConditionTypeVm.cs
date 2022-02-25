using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvdRentals.ViewModels
{
    public class ConditionTypeVm
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name value is required but provided.")]
        [MaxLength(150, ErrorMessage ="Name cannot more than 150 characters.")]
        [MinLength(3, ErrorMessage ="Name cannot be less than 3 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description value is required but provided.")]
        [MaxLength(500, ErrorMessage = "Description cannot more than 500 characters.")]
        public string Description { get; set; }
    }
}
