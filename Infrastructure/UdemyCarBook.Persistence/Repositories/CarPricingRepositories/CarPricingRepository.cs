using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Interfaces.CarInterfaces;
using UdemyCarBook.Application.Interfaces.CarPricingInterfaces;
using UdemyCarBook.Application.ViewModels;
using UdemyCarBook.Domain.Entities;
using UdemyCarBook.Persistence.Context;

namespace UdemyCarBook.Persistence.Repositories.CarPricingRepositories
{
    public class CarPricingRepository : ICarPricingRepository
    {
        private readonly CarBookContext _context;

        public CarPricingRepository(CarBookContext context)
        {
            _context = context;
        }

        public List<CarPricing> GetCarPricingWithCars()
        {
            var values = _context.CarPricings.Include(x => x.Car).ThenInclude(y => y.Name)
                .Include(z => z.Pricing).Where(t => t.PricingID == 2).ToList();
            return values;
        }

        public List<CarPricing> GetCarPricingWithTimePeriod()
        {

            //List<CarPricing> values = new List<CarPricing>();
            //using (var command = _context.Database.GetDbConnection().CreateCommand())
            //{
            //	command.CommandText = "Select * from (Select Model,PricingID,Amount From CarPricings Inner Join Cars On Cars.CarID=CarPricings.CarId Inner Join Brands On Brands.BrandID=Cars.BrandID) As SourceTable Pivot( Sum(Amount) For PricingID In ([2],[3],[4]) as PivotTable";
            //	command.CommandType = System.Data.CommandType.Text;
            //	_context.Database.OpenConnection();
            //	using (var reader = command.ExecuteReader())
            //	{
            //		while (reader.Read())
            //		{
            //			CarPricing carPricing = new CarPricing();
            //			Enumerable.Range(1, 3).ToList().ForEach(x =>
            //			{
            //				if (DBNull.Value.Equals(reader[x]))
            //				{
            //					carPricing.Amount;
            //				}
            //				else
            //				{
            //					carPricing.Amount;
            //				}

            //			});
            //			values.Add(carPricing);
            //		}
            //	}
            //	_context.Database.CloseConnection();
            //	return values;
            //}



            //var values = from x in _context.CarPricings
            //             group x by x.PricingID into y
            //             select new
            //             {

            //                 CarId = y.Key,
            //                 DailyPrice = y.Where(z => z.CarPricingID == 2).Sum(t => t.Amount),
            //                 WeeklyPrice = y.Where(z => z.CarPricingID == 3).Sum(t => t.Amount),
            //                 MonthlyPrice = y.Where(z => z.CarPricingID == 4).Sum(t => t.Amount)
            //             };

            //return values;

            throw new NotImplementedException();
        }

        public List<CarPricingViewModel> GetCarPricingWithTimePeriod2()
        {
            List<CarPricingViewModel> values = new List<CarPricingViewModel>();
            using (var command = _context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = @"
                SELECT BrandName,Model, [2] AS DailyAmount, [3] AS WeeklyAmount, [4] AS MonthlyAmount,CoverImageUrl
                FROM (
                    SELECT Cars.Model, CarPricings.PricingID, CarPricings.Amount, Cars.CoverImageUrl, Brands.Name AS BrandName
                    FROM CarPricings
                    INNER JOIN Cars ON Cars.CarID = CarPricings.CarId
                    INNER JOIN Brands ON Brands.BrandID = Cars.BrandID
                ) AS SourceTable
                PIVOT (
                    SUM(Amount)
                    FOR PricingID IN ([2], [3], [4])
                ) AS PivotTable ORDER BY DailyAmount;
                ";
                command.CommandType = System.Data.CommandType.Text;
                _context.Database.OpenConnection();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CarPricingViewModel carPricingViewModel = new CarPricingViewModel();
                        carPricingViewModel.Model = reader["Model"].ToString();
                        carPricingViewModel.coverImageUrl = reader["CoverImageUrl"].ToString();
                        carPricingViewModel.Amounts.Add(reader["DailyAmount"] == DBNull.Value ? 0 : (decimal)reader["DailyAmount"]);
                        carPricingViewModel.Amounts.Add(reader["WeeklyAmount"] == DBNull.Value ? 0 : (decimal)reader["WeeklyAmount"]);
                        carPricingViewModel.Amounts.Add(reader["MonthlyAmount"] == DBNull.Value ? 0 : (decimal)reader["MonthlyAmount"]);
                        carPricingViewModel.BrandName = reader["BrandName"].ToString();
                        values.Add(carPricingViewModel);
                    }

                }
                _context.Database.CloseConnection();
                return values;
            }
        }

    }
}
