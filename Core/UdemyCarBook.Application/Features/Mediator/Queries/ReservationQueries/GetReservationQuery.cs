using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Results.ReservationResults;

namespace UdemyCarBook.Application.Features.Mediator.Queries.ReservationQueries
{
    public class GetReservationQuery:IRequest<List<GetReservationQueryResult>>
    {
    }
}
