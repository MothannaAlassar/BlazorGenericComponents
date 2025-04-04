using SerialMakerBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerialMakerBlazor.Data
{
    public static class DataSeeder
    {
        public static void Seed(ApplicationDbContext context)
        {
            // Check if the country already exists
            if (!context.Countries.Any(c => c.Name == "Yemen"))
            {
                var yemen = new Country { Id = 1, Name = "Yemen" };
                context.Countries.Add(yemen);
                context.SaveChanges(); // Save to get the generated ID
            }

            // Check if governorates already exist
            var governorates = new List<Governorate>
        {
            new Governorate { Id = 1, Name = "Sana'a", CountryId = 1 },
            new Governorate { Id = 2, Name = "Aden", CountryId = 1 },
            new Governorate { Id = 3, Name = "Taiz", CountryId = 1 },
            new Governorate { Id = 4, Name = "Hodeidah", CountryId = 1 },
            new Governorate { Id = 5, Name = "Ibb", CountryId = 1 },
            new Governorate { Id = 6, Name = "Dhamar", CountryId = 1 },
            new Governorate { Id = 7, Name = "Hadhramaut", CountryId = 1 },
            new Governorate { Id = 8, Name = "Saada", CountryId = 1 }
        };

            foreach (var governorate in governorates)
            {
                if (!context.Governorates.Any(g => g.Name == governorate.Name && g.CountryId == 1))
                {
                    context.Governorates.Add(governorate);
                }
            }

            context.SaveChanges(); // Save added governorates

            // Check if cities already exist
            var cities = new List<City>
        {
            new City { Id = 1, Name = "Sana'a", GovernorateId = 1 },
            new City { Id = 2, Name = "Aden", GovernorateId = 2 },
            new City { Id = 3, Name = "Taiz", GovernorateId = 3 },
            new City { Id = 4, Name = "Hodeidah", GovernorateId = 4 },
            new City { Id = 5, Name = "Ibb", GovernorateId = 5 },
            new City { Id = 6, Name = "Dhamar", GovernorateId = 6 },
            new City { Id = 7, Name = "Al-Mukalla", GovernorateId = 7 },
            new City { Id = 8, Name = "Saada", GovernorateId = 8 }
        };

            foreach (var city in cities)
            {
                if (!context.Cities.Any(c => c.Name == city.Name && c.GovernorateId == city.GovernorateId))
                {
                    context.Cities.Add(city);
                }
            }

            context.SaveChanges(); // Save added cities
        }
    }
}
