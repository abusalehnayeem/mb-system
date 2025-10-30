using System.Collections.ObjectModel;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using MauiERP.UI.Models;
using MauiERP.UI.Services;

namespace MauiERP.UI.ViewModels
{
    public partial class DashboardViewModel : BaseViewModel
    {
        private readonly INavigationService _navigationService;

        public ObservableCollection<Kpi> Kpis { get; } = new();
        public ObservableCollection<ListItem> RecentItems { get; } = new();

        public DashboardViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            // Placeholder data for KPIs
            Kpis.Add(new Kpi { Name = "Revenue", Value = "$125,000" });
            Kpis.Add(new Kpi { Name = "New Orders", Value = "1,200" });
            Kpis.Add(new Kpi { Name = "Fill Rate", Value = "98.5%" });

            // Placeholder data for recent items (use correct ListItem properties and types)
            RecentItems.Add(new ListItem { Id = 1, PrimaryText = "Order #1023", SecondaryText = "Customer: John Doe", Status = "Shipped" });
            RecentItems.Add(new ListItem { Id = 2, PrimaryText = "Order #1024", SecondaryText = "Customer: Jane Smith", Status = "Pending" });
            RecentItems.Add(new ListItem { Id = 3, PrimaryText = "Order #1025", SecondaryText = "Customer: Acme Corp", Status = "Delivered" });
        }

        [RelayCommand]
        private async Task NavigateToDataEntry()
        {
            await _navigationService.NavigateToAsync("DataEntryPage");
        }
    }
}
