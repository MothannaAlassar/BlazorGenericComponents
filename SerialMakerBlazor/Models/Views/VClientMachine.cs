using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerialMakerBlazor.Models.Views
{
    public class VClientMachine
    {
        public int ID { get; set; }
        public int? ClientId { get; set; }
        public string MachineName { get; set; }
        public string MachineUser { get; set; }
        public string MachineCpu { get; set; }
        public string MachineHard { get; set; }
        public string MachineSerial { get; set; }
        public string OthersData { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; }
        public string ClientName { get; set; }
        public string PhoneNo { get; set; }
    }
}
