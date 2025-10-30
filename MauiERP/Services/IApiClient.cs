namespace MauiERP.Services
{
    public interface IApiClient
    {
        Task<T> GetAsync<T>(string endpoint);
        Task PostAsync<T>(string endpoint, T data);
        Task PutAsync<T>(string endpoint, T data);
        Task DeleteAsync(string endpoint);
    }
}
