using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface CarService
    {
        List<Car> GetAll();
        void Add(Car car);
        Car GetById(int carId);
        void Delete(Car car);
        void Update(Car car);


    }
}
