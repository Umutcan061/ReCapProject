using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> cars;
        public InMemoryCarDal()
        {
            cars = new List<Car> { new Car {CarId=1,BrandId=1,ColorId=1,DailyPrice=1500,ModelYear=1996,Description="MercedesBenz" },
            new Car{CarId=2,BrandId=2,ColorId=2,DailyPrice=20000,Description="BMW",ModelYear=2005 },
             new Car{CarId=3,BrandId=1,ColorId=2,DailyPrice=20000,Description="Mercedes A180",ModelYear=2005 },
             new Car{CarId=4,BrandId=2,ColorId=2,DailyPrice=20000,Description="BMW E30",ModelYear=2005 },
             new Car{CarId=5,BrandId=3,ColorId=2,DailyPrice=20000,Description="RANGE ROVER",ModelYear=2005 }};

        }


        public void Add(Car car)
        {
            cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;
            carToDelete = cars.SingleOrDefault(c => c.CarId == car.CarId);
            cars.Remove(carToDelete);


        }

        public List<Car> GetAll()
        {
            return cars;
        }

        public Car GetById(int carId)
        {
            Car refcar = null;
            refcar = cars.SingleOrDefault(car => car.CarId == carId);
            return refcar;

        }

        public void Update(Car car)
        {
            foreach (var c in cars)
            {
                if (c.CarId == car.CarId)
                {
                    c.DailyPrice = car.DailyPrice;
                    c.BrandId = car.BrandId;
                    c.Description = car.Description;
                    c.ModelYear = car.ModelYear;
                    c.ColorId = car.ColorId;


                }
                else
                {
                    Console.WriteLine("Aranan araç bulunamadı");
                }
            }
        }
    }
}
