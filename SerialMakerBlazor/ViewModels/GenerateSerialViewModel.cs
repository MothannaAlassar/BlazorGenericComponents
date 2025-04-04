using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SerialMakerBlazor.ViewModels
{
    public class GenerateTrialSerialViewModel
    {
        [Required(ErrorMessage = "ClientSerial is required.")]
        [StringLength(39, ErrorMessage = "ClientSerial cannot exceed 37 characters.")]
        public string ClientSerial { get; set; }

        [Required(ErrorMessage = "GeneratedSerial is required.")]
        [RegularExpression(@"^[A-Za-z0-9-]+$", ErrorMessage = "GeneratedSerial can only contain letters, numbers, and dashes.")]
        public string GeneratedSerial { get; set; }

        [Required(ErrorMessage = "Identifier is required.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Identifier must be between 3 and 20 characters.")]
        public string Identifier { get; set; }
    }
    public class GenerateMainSerialViewModel
    {
        [Required(ErrorMessage = "ClientSerial is required.")]
        [StringLength(32, ErrorMessage = "ClientSerial cannot exceed 20 characters.")]
        public string ClientSerial { get; set; }

        [Required(ErrorMessage = "GeneratedSerial is required.")]
        [RegularExpression(@"^[A-Za-z0-9-]+$", ErrorMessage = "GeneratedSerial can only contain letters, numbers, and dashes.")]
        public string GeneratedSerial { get; set; }

        [Required(ErrorMessage = "Identifier is required.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Identifier must be between 3 and 20 characters.")]
        public string Identifier { get; set; }
    }
    public class EncreptTextViewModel
    {
        [Required(ErrorMessage = "required.")]
        public string EncreptText { get; set; }

        //[Required(ErrorMessage = "required.")]
        public string DecreptText { get; set; }

       
    }
}
