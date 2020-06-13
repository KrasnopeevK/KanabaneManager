using AKSoftware.WebApi.Client;

namespace KanbaneManager.BlazorApp.Services
{
    public class CarService
    {
        private readonly string _baseUrl;

        ServiceClient client = new ServiceClient();

        public CarService(string url)
        {
            _baseUrl = url;
        }

        public string AccessToken
        {
            get => client.AccessToken;
            set
            {
                client.AccessToken = value; 
            }
        }
    }
}