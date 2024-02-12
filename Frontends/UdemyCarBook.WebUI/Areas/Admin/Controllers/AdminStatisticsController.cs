using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UdemyCarBook.Dto.AuthorDtos;
using UdemyCarBook.Dto.StatisticsDtos;

namespace UdemyCarBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/AdminStatistics")]
    public class AdminStatisticsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminStatisticsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();

            #region CarCount
            var responseMessage = await client.GetAsync("https://localhost:7238/api/Statistics/GetCarCount");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var apiResponse = JsonConvert.DeserializeObject<ApiResponse<ResultStatisticsDto>>(jsonData);
                ViewBag.CarCount = apiResponse?.Result?.carCount;

            }
            #endregion

            #region LocationCount
            var responseMessage2 = await client.GetAsync("https://localhost:7238/api/Statistics/GetLocationCount");
            if (responseMessage2.IsSuccessStatusCode)
            {
                var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
                var apiResponse2 = JsonConvert.DeserializeObject<ApiResponse<ResultStatisticsDto>>(jsonData2);
                ViewBag.LocationCount = apiResponse2?.Result?.locationCount;

            }
            #endregion

            #region AuthorCount
            var responseMessage3 = await client.GetAsync("https://localhost:7238/api/Statistics/GetAuthorCount");
            if (responseMessage3.IsSuccessStatusCode)
            {
                var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
                var apiResponse3 = JsonConvert.DeserializeObject<ApiResponse<ResultStatisticsDto>>(jsonData3);
                ViewBag.AuthorCount = apiResponse3?.Result?.authorCount;

            }
            #endregion

            #region BlogCount
            var responseMessage4 = await client.GetAsync("https://localhost:7238/api/Statistics/GetBlogCount");
            if (responseMessage4.IsSuccessStatusCode)
            {
                var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
                var apiResponse4 = JsonConvert.DeserializeObject<ApiResponse<ResultStatisticsDto>>(jsonData4);
                ViewBag.BlogCount = apiResponse4?.Result?.blogCount;

            }
            #endregion

            #region BrandCount
            var responseMessage5 = await client.GetAsync("https://localhost:7238/api/Statistics/GetBrandCount");
            if (responseMessage5.IsSuccessStatusCode)
            {
                var jsonData5 = await responseMessage5.Content.ReadAsStringAsync();
                var apiResponse5 = JsonConvert.DeserializeObject<ApiResponse<ResultStatisticsDto>>(jsonData5);
                ViewBag.BrandCount = apiResponse5?.Result?.brandCount;

            }
            #endregion

            #region AvgCarPriceDaily
            var responseMessage6 = await client.GetAsync("https://localhost:7238/api/Statistics/GetAvgRentPriceForDaily");
            if (responseMessage6.IsSuccessStatusCode)
            {
                var jsonData6 = await responseMessage6.Content.ReadAsStringAsync();
                var apiResponse6 = JsonConvert.DeserializeObject<ApiResponse<ResultStatisticsDto>>(jsonData6);
                ViewBag.avgPriceForDaily = apiResponse6?.Result?.avgPriceForDaily.ToString("0.00");

            }
            #endregion

            #region AvgCarPriceWeekly
            var responseMessage7 = await client.GetAsync("https://localhost:7238/api/Statistics/GetAvgRentPriceForWeekly");
            if (responseMessage7.IsSuccessStatusCode)
            {
                var jsonData7 = await responseMessage7.Content.ReadAsStringAsync();
                var apiResponse7 = JsonConvert.DeserializeObject<ApiResponse<ResultStatisticsDto>>(jsonData7);
                ViewBag.avgPriceForWeekly = apiResponse7?.Result?.avgPriceForWeekly.ToString("0.00");

            }
            #endregion

            #region AvgCarPriceMonthly
            var responseMessage8 = await client.GetAsync("https://localhost:7238/api/Statistics/GetAvgRentPriceForMonthly");
            if (responseMessage8.IsSuccessStatusCode)
            {
                var jsonData8= await responseMessage8.Content.ReadAsStringAsync();
                var apiResponse8 = JsonConvert.DeserializeObject<ApiResponse<ResultStatisticsDto>>(jsonData8);
                ViewBag.avgPriceForMonthly = apiResponse8?.Result?.avgPriceForMonthly.ToString("0.00");

            }
            #endregion

            #region CarCountByTransmissionAuto
            var responseMessage9 = await client.GetAsync("https://localhost:7238/api/Statistics/GetCarCountByTransmissionIsAuto");
            if (responseMessage9.IsSuccessStatusCode)
            {
                var jsonData9 = await responseMessage9.Content.ReadAsStringAsync();
                var apiResponse9 = JsonConvert.DeserializeObject<ApiResponse<ResultStatisticsDto>>(jsonData9);
                ViewBag.carCountByTransmissionAuto = apiResponse9?.Result?.carCountByTransmissionAuto;

            }
            #endregion

            #region BrandNameByMaxCar
            var responseMessage10 = await client.GetAsync("https://localhost:7238/api/Statistics/GetBrandNameByMaxCar");
            if (responseMessage10.IsSuccessStatusCode)
            {
                var jsonData10 = await responseMessage10.Content.ReadAsStringAsync();
                var apiResponse10 = JsonConvert.DeserializeObject<ApiResponse<ResultStatisticsDto>>(jsonData10);
                ViewBag.brandNameByMaxCar = apiResponse10?.Result?.brandNameByMaxCar;

            }
            #endregion

            #region BlogTitleByMaxBlogComment
            var responseMessage11 = await client.GetAsync("https://localhost:7238/api/Statistics/GetBlogTitleByMaxBlogComment");
            if (responseMessage11.IsSuccessStatusCode)
            {
                var jsonData11 = await responseMessage11.Content.ReadAsStringAsync();
                var apiResponse11 = JsonConvert.DeserializeObject<ApiResponse<ResultStatisticsDto>>(jsonData11);
                ViewBag.blogTitleByMaxBlogComment = apiResponse11?.Result?.blogTitleByMaxBlogComment;

            }
            #endregion

            #region CarCountByKmSmallerThan1000
            var responseMessage12 = await client.GetAsync("https://localhost:7238/api/Statistics/GetCarCountByKmSmallerThan1000");
            if (responseMessage12.IsSuccessStatusCode)
            {
                var jsonData12 = await responseMessage12.Content.ReadAsStringAsync();
                var apiResponse12 = JsonConvert.DeserializeObject<ApiResponse<ResultStatisticsDto>>(jsonData12);
                ViewBag.carCountByKmSmallerThan1000 = apiResponse12?.Result?.carCountByKmSmallerThan1000;

            }
            #endregion

            #region CarCountByFuelGasolineOrDiesel
            var responseMessage13 = await client.GetAsync("https://localhost:7238/api/Statistics/GetCarCountByFuelGasolineOrDiesel");
            if (responseMessage13.IsSuccessStatusCode)
            {
                var jsonData13 = await responseMessage13.Content.ReadAsStringAsync();
                var apiResponse13 = JsonConvert.DeserializeObject<ApiResponse<ResultStatisticsDto>>(jsonData13);
                ViewBag.carCountByFuelGasolineOrDiesel = apiResponse13?.Result?.carCountByFuelGasolineOrDiesel;

            }
            #endregion

            #region CarCountByFuelElectric
            var responseMessage14 = await client.GetAsync("https://localhost:7238/api/Statistics/GetCarCountByFuelElectric");
            if (responseMessage14.IsSuccessStatusCode)
            {
                var jsonData14 = await responseMessage14.Content.ReadAsStringAsync();
                var apiResponse14 = JsonConvert.DeserializeObject<ApiResponse<ResultStatisticsDto>>(jsonData14);
                ViewBag.carCountByFuelElectric = apiResponse14?.Result?.carCountByFuelElectric;

            }
            #endregion

            #region BrandAndModelByRentPriceMax
            var responseMessage15 = await client.GetAsync("https://localhost:7238/api/Statistics/GetBrandAndModelByRentPriceMax");
            if (responseMessage15.IsSuccessStatusCode)
            {
                var jsonData15 = await responseMessage15.Content.ReadAsStringAsync();
                var apiResponse15 = JsonConvert.DeserializeObject<ApiResponse<ResultStatisticsDto>>(jsonData15);
                ViewBag.brandAndModelByRentPriceMax = apiResponse15?.Result?.brandAndModelByRentPriceMax;

            }
            #endregion

            #region BrandAndModelByRentPriceMin
            var responseMessage16 = await client.GetAsync("https://localhost:7238/api/Statistics/GetBrandAndModelByRentPriceMin");
            if (responseMessage16.IsSuccessStatusCode)
            {
                var jsonData16 = await responseMessage16.Content.ReadAsStringAsync();
                var apiResponse16 = JsonConvert.DeserializeObject<ApiResponse<ResultStatisticsDto>>(jsonData16);
                ViewBag.brandAndModelByRentPriceMin = apiResponse16?.Result?.brandAndModelByRentPriceMin;

            }
            #endregion

            return View();
        }
    }
}
