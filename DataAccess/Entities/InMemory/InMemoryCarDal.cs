using DataAccess.Abstract;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Entities.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{ Id = 1, BrandId = 1, ColorId = 2, ModelYear = 2017, DailyPrice = 299, Description  = "Tesla ModelY SİYAH"},
                new Car{ Id = 2, BrandId = 2, ColorId = 1, ModelYear = 2017, DailyPrice = 299, Description  = "Toyota Supra BEYAZ"},
                new Car{ Id = 3, BrandId = 3, ColorId = 3, ModelYear = 2017, DailyPrice = 299, Description  = "Toyota Avensis GRİ"},
                new Car{ Id = 4, BrandId = 4, ColorId = 4, ModelYear = 2017, DailyPrice = 299, Description  = "Tesla ModelX Pembe"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete;
            carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}