using System.Diagnostics;

namespace MauiERP.Services
{
    public class LoggingService : ILoggingService
    {
        public void LogInfo(string message)
        {
            Debug.WriteLine($"[INFO] {message}");
        }

        public void LogWarning(string message)
        {
            Debug.WriteLine($"[WARNING] {message}");
        }

        public void LogError(string message, Exception ex = null)
        {
            Debug.WriteLine($"[ERROR] {message}");
            if (ex != null)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}
