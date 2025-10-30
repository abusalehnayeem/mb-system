using MauiERP.Services;

namespace MauiERP
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();

            AppDomain.CurrentDomain.UnhandledException += (sender, args) =>
            {
                var loggingService = ServiceHelper.Services.GetService<ILoggingService>();
                loggingService?.LogError("Unhandled exception", args.ExceptionObject as Exception);
            };
        }
    }
}
