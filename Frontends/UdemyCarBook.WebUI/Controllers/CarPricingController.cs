using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UdemyCarBook.Dto.CarPricingDtos;
namespace UdemyCarBook.WebUI.Controllers
{
    public class CarPricingController : Controller
    {
		private readonly IHttpClientFactory _httpClientFactory;

		public CarPricingController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}
		public async Task<IActionResult> Index()
        {
            ViewBag.v1 = "Fiyatlar";
            ViewBag.v2 = "Araç Fiyat Paketleri";

			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7238/api/CarPricings/GetCarPricingWithTimePeriodList");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultCarPricingListWithBrandModelDto>>(jsonData);
				return View(values);
			}
			return View();
			
        }
    }
}
