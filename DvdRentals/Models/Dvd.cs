using DvdRentals.Helpers;
using System.ComponentModel.DataAnnotations.Schema;

namespace DvdRentals.Models
{
    public class Dvd : BaseModel
    {
        public int Id { get; set; }

        [ForeignKey(nameof(Models.ConditionType))]
        public int ConditionTypeId { get; set; }
        
        [ForeignKey(nameof(Models.Movie))]
        public int MovieId { get; set; }

        [ForeignKey(nameof(Models.Distributor))]
        public int DistributorId { get; set; }

        //Navigation Properties
        public  ConditionType ConditionType { get; set; }
        public Movie Movie { get; set; }
        public Distributor Distributor { get; set; }
    }
}
