using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : Abstract.ICarDal
    {
       List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                //new Car { Id =1, ModelName="CAMRY HYBRID" ,BrandId="Toyota", ColorId =00121, DailyPrice=25000, ModelYear=2020,Description= "The powerful, stylish 2020 Camry Hybrid gives up nothing with its optimized fuel economy, advanced tech and stirring drive."},
                //new Car { Id =2, ModelName="Corolla HYBRID" ,BrandId="Toyota", ColorId =00124, DailyPrice=33450, ModelYear=2020,Description= "We have expanded our hybrid battery warranty to reflect our confidence in the quality, dependability and reliability of our products"},
                //new Car { Id =3, ModelName="Prius", BrandId="Toyota", ColorId =00129, DailyPrice=40000, ModelYear=2020,Description= "Take fuel efficiency to the next level by plugging in at home, at work or at any nearby public charging station."},
                //new Car { Id =4, ModelName="E-CLASS SEDAN", BrandId="Mercede Benz", ColorId =00120, DailyPrice=25000, ModelYear=2020,Description= "Suit your state of mind, or create a new atmosphere, anytime. Available 64-color LED ambient lighting includes multi-hue motifs, and soothing themes that cycle through colors."},
                //new Car { Id =5, ModelName="S-CLASS SEDAN", BrandId="Mercede Benz", ColorId =00169, DailyPrice=33450, ModelYear=2020,Description= "Supportive seats are appointed in a spectrum of upholstery options. Trim options include two natural-grain woods."},
                //new Car { Id =6, ModelName="Maybach S SEDAN", BrandId="Mercede Benz", ColorId =00147, DailyPrice=40000, ModelYear=2020,Description= "Crisp, upright lines maximize cabin space and minimize overhangs. Even sportier AMG Line and blackout Night Package options each offer a pair of wheel designs, for a total of six choices from 18 to 20 inches."},
                //new Car { Id =7, ModelName="Golf", BrandId="VOLKSWAGEN", ColorId =03684, DailyPrice=25000, ModelYear=2020,Description= "With elegant exterior styling that features an aerodynamic fastback design, the Arteon is a driving experience all its own."},
                //new Car { Id =8, ModelName="Passat", BrandId="VOLKSWAGEN", ColorId =01457, DailyPrice=33450, ModelYear=2020,Description= "The look may be classic, but it’s far from the only story. We gave the Arteon a host of performance features that help make it as much fun to drive as it is to stare at."},
                //new Car { Id =9, ModelName="Arteon", BrandId="VOLKSWAGEN", ColorId =01019, DailyPrice=40000, ModelYear=2020,Description= "The standard and available features on the Arteon help explain why it’s justifiably called a premium sedan."},
                //new Car { Id =10, ModelName="5 Series Sedan", BrandId="BMW", ColorId =35147, DailyPrice=25000, ModelYear=2020,Description= "Safety is a core value to us. And while we can’t predict everything you might encounter, we can and do spend long hours trying to help you prepare for it."},
                //new Car { Id =11, ModelName="3 Series Sedan", BrandId="BMW", ColorId =24996, DailyPrice=33450, ModelYear=2020,Description= "The generous configuration and premium features in the BMW X7 evoke a feeling of spacious freedom while the engineering ensures driving comfort from the inside out."},
                //new Car { Id =12, ModelName="X7", BrandId="BMW", ColorId =54526, DailyPrice=40000, ModelYear=2020,Description= "Enjoy a curated collection of life-improving technology – from standard safety features to cutting-edge developments in onboard driver assistance systems."}
            };

        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car productToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(productToDelete);
        }

        public List<CarDetailDto> GetCarDetail()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByModelId(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

     
        public void Update(Car car)
        {
            Car productToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);

            productToUpdate.BrandId = car.BrandId;
            productToUpdate.ColorId = car.ColorId;
            productToUpdate.DailyPrice = car.DailyPrice;
            productToUpdate.Description = car.Description;
            productToUpdate.ModelYear = car.ModelYear;

        }
    }
}
