using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        void AddCar(Car car);
        void UpdateCar(Car car);
        void DeleteCar(Car car);
        List<Car> GetCarsById(int Id);
        List<Car> GetAll();
    }
}
