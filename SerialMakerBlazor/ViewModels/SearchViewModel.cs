using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerialMakerBlazor.ViewModels
{
    public class SearchViewModel
    {
        public string SearchVal { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string PlanName { get; set; }
        public string EnableState { get; set; }
        public string UsedState { get; set; }
        public List<string> VoucherUsedStates { get; set; }
        public List<string> VoucherEnableStates { get; set; }
        public List<string> VoucherPlans { get; set; }
        public bool IsShowDate { get; set; } = true;
        public bool IsShowPlans { get; set; } = false;
        public bool IsShowUsedStates { get; set; } = false;
        public bool IsShowEnableStates { get; set; } = false;
        public bool IsAccountKashf { get; set; } = false;

        public long AccountId { get; set; }
        public string AccountName { get; set; }
        public string CurrencyCode { get; set; }
        public bool ShowOldPalance { get; set; } = true;
        public bool ShowSumry { get; set; } = false;
    }
}
