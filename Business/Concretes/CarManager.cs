using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CarManager:CarService
    {
        private ICarDal carDal;

        public CarManager(ICarDal carDal)
        {
            this.carDal = carDal;
        }

        public void Add(Car car)
        {
            carDal.Add(car);
        }

        public void Delete(Car car)
        {
            carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return carDal.GetAll();
        }

        public Car GetById(int carId)
        {
            return carDal.GetById(carId);
        }

        public void Update(Car car)
        {
            carDal.Update(car);
        }
    }
}
