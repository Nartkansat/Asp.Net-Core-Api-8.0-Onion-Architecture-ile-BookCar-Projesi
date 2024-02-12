using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Queries.ReservationQueries;
using UdemyCarBook.Application.Features.Mediator.Results.FeatureResults;
using UdemyCarBook.Application.Features.Mediator.Results.ReservationResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.ReservationHandlers
{
    public class GetReservationQueryHandler : IRequestHandler<GetReservationQuery, List<GetReservationQueryResult>>
    {
        private readonly IRepository<Reservation> _repository;

        public GetReservationQueryHandler(IRepository<Reservation> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetReservationQueryResult>> Handle(GetReservationQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetReservationQueryResult
            {
                Age = x.Age,
                CarID = x.CarID,
                Description = x.Description,
                DriverLicenseYear = x.DriverLicenseYear,
                DropOffLocationID = x.DropOffLocationID,
                Email = x.Email,
                Name = x.Name,
                Phone = x.Phone,
                PickUpLocationID = x.PickUpLocationID,
                ReservationID = x.ReservationID,
                Status = x.Status,
                Surname = x.Surname
            }).ToList();
        }
    }
}
