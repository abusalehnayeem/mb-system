namespace MauiERP;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(OrderDetailPage), typeof(OrderDetailPage));
		Routing.RegisterRoute(nameof(AddItemPage), typeof(AddItemPage));
	}
}
