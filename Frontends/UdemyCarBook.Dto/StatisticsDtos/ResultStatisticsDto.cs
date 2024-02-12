using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Dto.StatisticsDtos
{
    public class ResultStatisticsDto
    {
        public int carCount { get; set; }
        public int locationCount { get; set; }
        public int authorCount { get; set; }
        public int blogCount { get; set; }
        public int brandCount { get; set; }
        public decimal avgPriceForDaily { get; set; }
        public decimal avgPriceForWeekly { get; set; }
        public decimal avgPriceForMonthly { get; set; }
        public int carCountByTransmissionAuto { get; set; }
        public int carCountByKmSmallerThan1000 { get; set; }
        public int carCountByFuelGasolineOrDiesel { get; set; }
        public int carCountByFuelElectric { get; set; }
        public string brandAndModelByRentPriceMax { get; set; }
        public string brandAndModelByRentPriceMin { get; set; }
        public string brandNameByMaxCar { get; set; }
        public string blogTitleByMaxBlogComment { get; set; }
    }
}
