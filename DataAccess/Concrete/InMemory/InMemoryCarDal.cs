using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
            new Car{Id= 1, BrandId=1, ColorId=1, DailyPrice=175, ModelYear=2006, Description="BMW 1.16i", },
            new Car{Id= 2, BrandId=1, ColorId=2, DailyPrice=275, ModelYear=2016, Description="BMW 3,20i", },
            new Car{Id= 3, BrandId=2, ColorId=1, DailyPrice=300, ModelYear=2019, Description="Mercedes E250", },
            new Car{Id= 4, BrandId=3, ColorId=3, DailyPrice=200, ModelYear=2013, Description="Ford Fiesta", }
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c =>c.Id == car.Id);

            _cars.Remove(carToDelete);
           

        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;

        }
    }
}
