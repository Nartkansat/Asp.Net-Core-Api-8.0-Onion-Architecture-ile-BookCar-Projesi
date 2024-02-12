using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UdemyCarBook.Dto.StatisticsDtos;

namespace UdemyCarBook.WebUI.ViewComponents.DefaultViewComponents
{
    public class _DefaultStatisticsComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultStatisticsComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client =_httpClientFactory.CreateClient();

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

            #region BrandCount
            var responseMessage5 = await client.GetAsync("https://localhost:7238/api/Statistics/GetBrandCount");
            if (responseMessage5.IsSuccessStatusCode)
            {
                var jsonData5 = await responseMessage5.Content.ReadAsStringAsync();
                var apiResponse5 = JsonConvert.DeserializeObject<ApiResponse<ResultStatisticsDto>>(jsonData5);
                ViewBag.BrandCount = apiResponse5?.Result?.brandCount;

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

            return View(); 
        }
    }
}
