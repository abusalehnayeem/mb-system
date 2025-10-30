namespace MauiERP.UI;

using MauiERP.UI.Views;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(DetailPage), typeof(DetailPage));
        Routing.RegisterRoute(nameof(DataEntryPage), typeof(DataEntryPage));
    }
}
