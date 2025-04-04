using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerialMakerBlazor.Services
{
    public interface ILoggerService
    {
        void AddErrorLog(Exception ex);
        void AddErrorLog(string message);
    }
}
