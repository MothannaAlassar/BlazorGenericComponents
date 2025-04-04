using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SerialMakerBlazor.Models
{
    public class SysVersion
    {
        public int ID { get; set; }
        [Required]
        public string VersionName { get; set; }
        [Required]
        public string VersionNumber { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedUser { get; set; }
        [Required]
        public DateTime? VersionDate { get; set; }
        [Required]
        public int? SystemTypeId { get; set; }
        [ForeignKey("SystemTypeId")]
        public SystemType SystemType { get; set; }
    }
}
