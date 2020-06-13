using System.Threading.Tasks;
using AKSoftware.WebApi.Client;
using KanbaneManager.BlazorApp.Models;

namespace KanbaneManager.BlazorApp.Services
{
    public class AuthenticationService
    {

        private readonly string _baseUrl;

        ServiceClient client = new ServiceClient();

        public AuthenticationService(string url)
        {
            _baseUrl = url;
        }

        public async Task<UserManagerResponse> LoginUserAsync(LoginRequest request)
        {
            var response = await client.PostAsync<UserManagerResponse>($"{_baseUrl}/login", request);
            return response.Result;
        }

    }
}