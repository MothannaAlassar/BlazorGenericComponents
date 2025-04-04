using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SerialMakerBlazor.Models
{
    // Country.cs
    public class Country
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Name { get; set; } // Name of the country
        public ICollection<Governorate> Governorates { get; set; } // Relationship with Governorate
    }
}
