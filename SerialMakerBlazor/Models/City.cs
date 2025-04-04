using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SerialMakerBlazor.Models
{
    // City.cs
    public class City
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; } // Unique identifier for the city
        public string Name { get; set; } // Name of the city
        public int GovernorateId { get; set; } // Foreign key
        public Governorate Governorate { get; set; } // Relationship with Governorate
    }
}
