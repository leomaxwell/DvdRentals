﻿using DvdRentals.Helpers;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DvdRentals.Models
{
    public class RentalDvd : BaseModel
    {
        [Key]
        [ForeignKey(nameof(Models.Rental))]
        public int RentalId { get; set; }
        
        [Key]
        [ForeignKey(nameof(Models.Dvd))]
        public int DvdId { get; set; }

        //Navigation Properties
        public Rental Rental { get; set; }
        public Dvd Dvd { get; set; }
    }
}
