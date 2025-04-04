using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SerialMakerBlazor.Models
{
    public class ClientMachine
    {
        public int ID { get; set; }
        [Required]
        public int? ClientId { get; set; }
        [ForeignKey("ClientId")]
        public Client Client { get; set; }
        [Required]
        public string MachineName { get; set; }
        [Required]
        public string MachineUser { get; set; }
        [Required]
        public string MachineCpu { get; set; }
        [Required]
        public string MachineHard { get; set; }
        [Required]
        public string MachineSerial { get; set; }
        public string OthersData { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; }
    }
}
