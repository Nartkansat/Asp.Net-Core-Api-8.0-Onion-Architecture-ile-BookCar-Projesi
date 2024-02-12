using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using UdemyCarBook.Application.Features.Mediator.Results.StatisticsResults;
using UdemyCarBook.Application.Interfaces.StatisticsInterfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.StatisticsHandlers
{
    public class GetBrandAndModelByRentPriceMaxQueryHandler : IRequestHandler<GetBrandAndModelByRentPriceMaxQuery, GetBrandAndModelByRentPriceMaxQueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetBrandAndModelByRentPriceMaxQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetBrandAndModelByRentPriceMaxQueryResult> Handle(GetBrandAndModelByRentPriceMaxQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetBrandAndModelByRentPriceMax();
            return new GetBrandAndModelByRentPriceMaxQueryResult
            {
                BrandAndModelByRentPriceMax = values
            };
        }
    }
}
