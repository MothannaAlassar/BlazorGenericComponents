using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerialMakerBlazor.Data
{
    public class AppUser : IdentityUser
    {
        public string FullName { get; set; }
        public string RoleName { get; set; }
        public bool IsStop { get; set; } = false;

    }
}
