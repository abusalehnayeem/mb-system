using Microsoft.Extensions.Logging;
using MauiERP.UI.Views;
using MauiERP.UI.ViewModels;
using MauiERP.UI.Services;

namespace MauiERP.UI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            // Register Views and ViewModels
            builder.Services.AddSingleton<DashboardPage>();
            builder.Services.AddSingleton<DashboardViewModel>();

            builder.Services.AddSingleton<ListsPage>();
            builder.Services.AddSingleton<ListsViewModel>();

            builder.Services.AddSingleton<SettingsPage>();
            builder.Services.AddSingleton<SettingsViewModel>();

            builder.Services.AddTransient<DetailPage>();
            builder.Services.AddTransient<DetailViewModel>();

            builder.Services.AddTransient<DataEntryPage>();
            builder.Services.AddTransient<DataEntryViewModel>();

            // Register Services
            builder.Services.AddSingleton<INavigationService, NavigationService>();
            builder.Services.AddSingleton<IApiClient, ApiClient>();
            builder.Services.AddSingleton<ILoggerService, LoggerService>();

            var app = builder.Build();

            // Configure global exception handling
            var logger = app.Services.GetRequiredService<ILoggerService>();
            GlobalExceptionHandler.UnhandledException += (sender, args) =>
            {
                logger.LogError(args.ExceptionObject as Exception);
                // This is a simple error display strategy. A more robust solution
                // would be to navigate to an error page.
                MainThread.BeginInvokeOnMainThread(async () =>
                {
                    await App.Current.MainPage.DisplayAlert("Error", "An unexpected error occurred.", "OK");
                });
            };

            return app;
        }
    }
}
