using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
       
        List<Car> _cars;
        public InMemoryCarDal()
        {

            _cars = new List<Car>
            {
                new Car{BrandId=1,CarId=1,ColorId=1,DailyPrice=10000,ModelYear=2014,Description="2. el"},
                new Car{BrandId=2,CarId=2,ColorId=2,DailyPrice=40000,ModelYear=2015,Description="2. el"},
                new Car{BrandId=3,CarId=3,ColorId=3,DailyPrice=50000,ModelYear=2016,Description="2. el"},
                new Car{BrandId=4,CarId=4,ColorId=4,DailyPrice=60000,ModelYear=2017,Description="2. el"},
                new Car{BrandId=5,CarId=5,ColorId=5,DailyPrice=80000,ModelYear=2018,Description="2. el"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete;
            carToDelete = _cars.SingleOrDefault(c=>c.CarId==car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
          return  _cars.Where(c => c.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate;
            carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.CarId = car.CarId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
