using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{Id = 1, DailyPrice= 145000, ModelYear = 2016, Description = "Orta Segment" },
                new Car{Id = 2, DailyPrice= 80000, ModelYear = 2008, Description = "Düşük-Orta Segment Araç" },
                new Car{Id = 3, DailyPrice= 900000, ModelYear = 2019, Description = "Yüksek Segment Araç" },
                new Car{Id = 4, DailyPrice= 35000, ModelYear = 2001, Description = "Düşük Segment Araç" },
                new Car{Id = 5, DailyPrice= 2650000, ModelYear = 2021, Description = "Çok Yüksek Segment Araç" }
            };
        }

        public void Add(Car entity)
        {
            throw new NotImplementedException();
        }

        public void AddCar(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteCar(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id == car.Id);
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
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateCar(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
