using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorGenericComponents.Helpers
{
    public enum MessageType
    {
        Default = 0,
        Success = 1,
        Error = 2,
        Warning = 3
    }
    public enum RedirectTypeEnum
    {
        None,
        AccessDenied,
        NotFound,
    }
    enum RandomValueType
    {
        numbers,
        up,
        low,
        rand
    }
}
