using Business.Abstract;
using DataAccess.Abstract;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Entities
{
    public class CarManager : ICarService
    {
        ICarDal _CarDal;

        public CarManager (ICarDal carDal)
        {
            _CarDal = carDal;
        }
        public List<Car> GetAll()
        {
            return _CarDal.GetAll();
        }
    }
}
