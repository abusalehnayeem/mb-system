using System.Diagnostics;

namespace MauiERP.UI.Services
{
    public class LoggerService : ILoggerService
    {
        public void Log(string message)
        {
            Debug.WriteLine(message);
        }

        public void LogError(Exception ex)
        {
            Debug.WriteLine(ex);
        }
    }
}
