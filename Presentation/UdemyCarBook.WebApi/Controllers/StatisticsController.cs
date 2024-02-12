using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Queries.StatisticsQueries;

namespace UdemyCarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StatisticsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetCarCount")]
        public IActionResult GetCarCount()
        {
            var values = _mediator.Send(new GetCarCountQuery());
            return Ok(values);
        }
        [HttpGet("GetLocationCount")]
        public IActionResult GetLocationCount()
        {
            var values = _mediator.Send(new GetLocationCountQuery());
            return Ok(values);
        }
        [HttpGet("GetAuthorCount")]
        public IActionResult GetAuthorCount()
        {
            var values = _mediator.Send(new GetAuthorCountQuery());
            return Ok(values);
        }
        [HttpGet("GetBlogCount")]
        public IActionResult GetBlogCount()
        {
            var values = _mediator.Send(new GetBlogCountQuery());
            return Ok(values);
        }
        [HttpGet("GetBrandCount")]
        public IActionResult GetBrandCount()
        {
            var values = _mediator.Send(new GetBrandCountQuery());
            return Ok(values);
        }
        [HttpGet("GetAvgRentPriceForDaily")]
        public IActionResult GetAvgRentPriceForDaily()
        {
            var values = _mediator.Send(new GetAvgRentPriceForDailyQuery());
            return Ok(values);
        }
        [HttpGet("GetAvgRentPriceForWeekly")]
        public IActionResult GetAvgRentPriceForWeekly()
        {
            var values = _mediator.Send(new GetAvgRentPriceForWeeklyQuery());
            return Ok(values);
        }
        [HttpGet("GetAvgRentPriceForMonthly")]
        public IActionResult GetAvgRentPriceForMonthly()
        {
            var values = _mediator.Send(new GetAvgRentPriceForMonthlyQuery());
            return Ok(values);
        }
        [HttpGet("GetCarCountByTransmissionIsAuto")]
        public IActionResult GetCarCountByTransmissionIsAuto()
        {
            var values = _mediator.Send(new GetCarCountByTransmissionIsAutoQuery());
            return Ok(values);
        }
        [HttpGet("GetBrandNameByMaxCar")]
        public IActionResult GetBrandNameByMaxCar()
        {
            var values = _mediator.Send(new GetBrandNameByMaxCarQuery());
            return Ok(values);
        }
        [HttpGet("GetBlogTitleByMaxBlogComment")]
        public IActionResult GetBlogTitleByMaxBlogComment()
        {
            var values = _mediator.Send(new GetBlogTitleByMaxBlogCommentQuery());
            return Ok(values);
        }
        [HttpGet("GetCarCountByKmSmallerThan1000")]
        public IActionResult GetCarCountByKmSmallerThan1000()
        {
            var values = _mediator.Send(new GetCarCountByKmSmallerThan1000Query());
            return Ok(values);
        }
        [HttpGet("GetCarCountByFuelGasolineOrDiesel")]
        public IActionResult GetCarCountByFuelGasolineOrDiesel()
        {
            var values = _mediator.Send(new GetCarCountByFuelGasolineOrDieselQuery());
            return Ok(values);
        }
        [HttpGet("GetCarCountByFuelElectric")]
        public IActionResult GetCarCountByFuelElectric()
        {
            var values = _mediator.Send(new GetCarCountByFuelElectricQuery());
            return Ok(values);
        }
        [HttpGet("GetBrandAndModelByRentPriceMax")]
        public IActionResult GetBrandAndModelByRentPriceMax()
        {
            var values = _mediator.Send(new GetBrandAndModelByRentPriceMaxQuery());
            return Ok(values);
        }
        [HttpGet("GetBrandAndModelByRentPriceMin")]
        public IActionResult GetBrandAndModelByRentPriceMin()
        {
            var values = _mediator.Send(new GetBrandAndModelByRentPriceMinQuery());
            return Ok(values);
        }
    }
}
