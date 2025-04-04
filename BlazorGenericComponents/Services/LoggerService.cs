using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorGenericComponents.Services
{
    public class LoggerService : ILoggerService
    {
        private static readonly Logger Baselogger = LogManager.GetCurrentClassLogger();
        public LoggerService()
        {

        }
        public void AddErrorLog(Exception ex)
        {
            Baselogger.Error($"{Environment.NewLine}----------------- Date Of Exception: {DateTime.Now}  ------------------{Environment.NewLine}");
            Baselogger.Error(ex);
            Baselogger.Error("" + Environment.NewLine);
        }
        public void AddErrorLog(string message)
        {
            Baselogger.Error($"{Environment.NewLine}----------------- Date Of Exception: {DateTime.Now}  ------------------{Environment.NewLine}");
            Baselogger.Error(message);
            Baselogger.Error("" + Environment.NewLine);
        }
    }
}
