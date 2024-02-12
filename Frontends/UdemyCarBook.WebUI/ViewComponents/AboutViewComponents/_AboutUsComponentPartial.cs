using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UdemyCarBook.Dto.AboutDtos;

namespace UdemyCarBook.WebUI.ViewComponents.AboutViewComponents
{
    public class _AboutUsComponentPartial:ViewComponent
    {
        // Api Consume işlemi yapacaz.
        // Api'den gelen verileri view tarafında göstermek.

        private readonly IHttpClientFactory _httpClientFactory;

        public _AboutUsComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            // istekte bulunmak için istemci(client) oluşturduk
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7238/api/Abouts");

            //200'lü kod için 200=başarılı
            if (responseMessage.IsSuccessStatusCode)
            {
                //response messageden gelen veriyi string formatta oku
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                //Dto oluşturup, dto kullandık, Dto vt'deki kısmı karşılıyor. Api'den
                var values = JsonConvert.DeserializeObject<List<ResultAboutDto>>(jsonData);

                return View(values);
            }
            return View();
        }
    }
}
