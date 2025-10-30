namespace MauiERP.UI.Services
{
    public interface ILoggerService
    {
        void Log(string message);
        void LogError(Exception ex);
    }
}
