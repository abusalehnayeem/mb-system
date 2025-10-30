namespace MauiERP.Services
{
    public class ApiClient : IApiClient
    {
        private readonly HttpClient _httpClient;

        public ApiClient()
        {
            _httpClient = new HttpClient();
        }

        public Task<T> GetAsync<T>(string endpoint)
        {
            // Placeholder implementation
            return Task.FromResult(default(T));
        }

        public Task PostAsync<T>(string endpoint, T data)
        {
            // Placeholder implementation
            return Task.CompletedTask;
        }

        public Task PutAsync<T>(string endpoint, T data)
        {
            // Placeholder implementation
            return Task.CompletedTask;
        }

        public Task DeleteAsync(string endpoint)
        {
            // Placeholder implementation
            return Task.CompletedTask;
        }
    }
}
