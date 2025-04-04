using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SerialMakerBlazor.Models
{
    // Governorate.cs
    public class Governorate
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Name { get; set; } // Name of the governorate

        public int CountryId { get; set; } // Foreign key
        public Country Country { get; set; } // Relationship with Country

        public ICollection<City> Cities { get; set; } // Relationship with City
    }
}
