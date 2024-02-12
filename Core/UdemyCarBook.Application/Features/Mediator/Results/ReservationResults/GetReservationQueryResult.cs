using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Results.ReservationResults
{
    public class GetReservationQueryResult
    {
        public int ReservationID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        // ilişki yapmak için burada nullable(?) kullandık
        public int? PickUpLocationID { get; set; }
        public int? DropOffLocationID { get; set; }

        public int CarID { get; set; }
        public int Age { get; set; }
        public int DriverLicenseYear { get; set; }
        public string Status { get; set; }

        // isteğe bağlı
        public string? Description { get; set; }

    }
}
