using Microsoft.AspNetCore.SignalR;

namespace UdemyCarBook.WebApi.Hubs
{
    public class CarHub:Hub
    {
        //SignalR ile çalışma, anlık veri almak için SignalR kullanılır.
        private readonly IHttpClientFactory _httpClientFactory;

        public CarHub(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task SendCarCount()
        {
            var client = _httpClientFactory.CreateClient();

            #region CarCount
            var responseMessage = await client.GetAsync("https://localhost:7238/api/Statistics/GetCarCount");
           
            var value = await responseMessage.Content.ReadAsStringAsync();
            await Clients.All.SendAsync("ReceiveCarCount",value);
            
            #endregion
        }
    }
}
