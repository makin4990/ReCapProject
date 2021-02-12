using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.WebSockets;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal: EfEntityRepositoryBase<Car,CarsContext>,ICarDal
    {
        public List<CarDetailDto> GetCarDetail()
        {
            using (CarsContext context = new CarsContext())
            {
                var result = from c in context.Cars
                    join b in context.Brands on c.BrandId equals b.Id
                    join cl in context.Colors on c.ColorId equals cl.Id
                    select new CarDetailDto
                    {
                        CarId = c.Id, CarName = c.Name, ColorName = cl.Name,
                        BrandName = b.Name, DailyPrice = c.DailyPrice, ModelYear = c.ModelYear
                    };
                return result.ToList();
            }
        }

    }
}
