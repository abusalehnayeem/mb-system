namespace MauiERP.UI.Services
{
    public class ApiClient : IApiClient
    {
        public async Task<bool> LoginAsync(string username, string password)
        {
            // Placeholder implementation
            await Task.Delay(1000); // Simulate network latency
            return true;
        }
    }
}
