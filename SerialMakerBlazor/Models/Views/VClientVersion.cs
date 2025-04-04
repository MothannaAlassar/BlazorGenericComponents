using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerialMakerBlazor.Models.Views
{
    public class VClientVersion
    {
        public int ID { get; set; }
        public int? ClientId { get; set; }
        public int? VersionId { get; set; }
        public int? SysTypeId { get; set; }
        public string TypeLicence { get; set; }//نوع النسخة تجريبي او نسخه فعليه
        public string TypeInstallation { get; set; }//نوع التثبيت نقطة مرتبطة بسيرفر آخر او نسخة مع قواعد البيانات
        public string Address { get; set; }
        public string MobileNo { get; set; }
        public string NameOfWork { get; set; }
        public string SysRank { get; set; }
        public string DatabaseName { get; set; }
        public string Notes { get; set; }
        public int? CountryId { get; set; }
        public int? GovernorateId { get; set; }
        public int? CityId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; }
        public string ClientName { get; set; }
        public string PhoneNo { get; set; }
        public string SysName { get; set; }
        public string VersionName { get; set; }
        public string VersionNumber { get; set; }
       
    }
}
