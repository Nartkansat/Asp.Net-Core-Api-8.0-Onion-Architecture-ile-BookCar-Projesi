using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using UdemyCarBook.Dto.BrandDtos;
using UdemyCarBook.Dto.RentACarDtos;

namespace UdemyCarBook.WebUI.Controllers
{
    public class RentACarListController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public RentACarListController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async  Task<IActionResult> Index(int id)
        {
            ViewBag.v1 = "Araçlarımız";
            ViewBag.v2 = "Uygun Araçlar";

            var bookpickdate = TempData["bookpickdate"];
            var bookoffdate = TempData["bookoffdate"];
            var timepick = TempData["timepick"];
            var timeoff = TempData["timeoff"];
            var locationID = TempData["locationID"];
            
            ViewBag.bookpickdate = bookpickdate;
            ViewBag.bookoffdate = bookoffdate;
            ViewBag.timepick = timepick;
            ViewBag.timeoff = timeoff;
            ViewBag.locationID = locationID;

            //filterRentACarDto.locationID = int.Parse((string)locationID);
            //filterRentACarDto.available = true;
            id = int.Parse((string)locationID);

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7238/api/RentACars?LocationID={id}&Available=true");            
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();   
                var values = JsonConvert.DeserializeObject<List<FilterRentACarDto>>(jsonData);
                return View(values);
            }

            return View();
        }
    }
}
