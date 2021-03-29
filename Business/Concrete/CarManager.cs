using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if (car.DailyPrice > 0)
            {
                _carDal.Add(car);
                return new SuccessResult(Messages.CarAdded);
            }
                else
                {
                return new ErrorResult(Messages.InvalidDailyPrice);
                }
        }
        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }
        public IResult Update(Car car)
        {
            if (car.DailyPrice > 0)
            {
                _carDal.Update(car);
                return new SuccessResult(Messages.CarUpdated);
            }
            else
            {
                return new ErrorResult(Messages.InvalidDailyPrice);
            }
        }

        public IDataResult<List<Car>> GetAll()
        {
            return (IDataResult<List<Car>>)_carDal.GetAll();
        }
        public IDataResult<Car> GetById(int Id)
        {
            return (IDataResult<Car>)_carDal.Get(c => c.Id == Id);
        }
        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return (IDataResult<List<Car>>)_carDal.GetAll(b => b.BrandId == brandId);
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            return (IDataResult<List<Car>>)_carDal.GetAll(c => c.ColorId == colorId);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return (IDataResult<List<CarDetailDto>>)_carDal.GetCarDetails();
        }
    }
}
