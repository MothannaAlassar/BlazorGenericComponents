using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorGenericComponents.Services
{
    public interface ILoggerService
    {
        void AddErrorLog(Exception ex);
        void AddErrorLog(string message);
    }
}
