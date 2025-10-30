// Based on https://github.com/dotnet/maui/discussions/653#discussioncomment-11267333
namespace MauiERP.UI.Services
{
    public static class GlobalExceptionHandler
    {
        public static event UnhandledExceptionEventHandler UnhandledException;

        static GlobalExceptionHandler()
        {
            AppDomain.CurrentDomain.UnhandledException += (sender, args) =>
            {
                UnhandledException?.Invoke(sender, args);
            };

            TaskScheduler.UnobservedTaskException += (sender, args) =>
            {
                UnhandledException?.Invoke(sender, new UnhandledExceptionEventArgs(args.Exception, false));
            };

#if IOS
            // For iOS and Mac Catalyst
            ObjCRuntime.Runtime.MarshalManagedException += (_, args) =>
            {
                args.ExceptionMode = ObjCRuntime.MarshalManagedExceptionMode.UnwindNativeCode;
            };
#elif ANDROID
            // For Android
            Android.Runtime.AndroidEnvironment.UnhandledExceptionRaiser += (sender, args) =>
            {
                args.Handled = true;
                UnhandledException?.Invoke(sender, new UnhandledExceptionEventArgs(args.Exception, true));
            };
#endif
        }
    }
}
