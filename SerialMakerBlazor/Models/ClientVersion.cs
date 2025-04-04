using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SerialMakerBlazor.Models
{
    public class ClientVersion
    {
        public int ID { get; set; }
        [Required]
        public int? ClientId { get; set; }
        [Required]
        public int? VersionId { get; set; }
        [Required]
        public int? SysTypeId { get; set; }
        [Required]
        public string TypeLicence { get; set; }//نوع النسخة تجريبي او نسخه فعليه
        [Required]
        public string TypeInstallation { get; set; }//نوع التثبيت نقطة مرتبطة بسيرفر آخر او نسخة مع قواعد البيانات
        [Required]
        public string Address { get; set; }
        [Required]
        public string MobileNo { get; set; }
        [Required]
        public string NameOfWork { get; set; }
        [Required]
        public string SysRank { get; set; }
        [Required]
        public string DatabaseName { get; set; }
        public string Notes { get; set; }
        [Required]
        public int? CountryId { get; set; }
        [Required]
        public int? GovernorateId { get; set; }
        [Required]
        public int? CityId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; }
        [ForeignKey("ClientId")]
        public Client Client { get; set; }
        [ForeignKey("VersionId")]
        public SysVersion SysVersion { get; set; }
        [ForeignKey("SysTypeId")]
        public SystemType SystemType { get; set; }
    }
}
