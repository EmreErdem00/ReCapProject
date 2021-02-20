using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _iCarDal;
        

        public CarManager(ICarDal carDal )
        {
            _iCarDal = carDal;
        }

        [ValidationAspect(typeof(CarValidator))]
        public IResult Add (Car car)
        {
            ValidationTool.Validate(new CarValidator(), car);
           _iCarDal.Add(car);
            return new SuccessResult();
        }

        public IResult Delete(Car car)
        {
            _iCarDal.Delete(car);
            return new SuccessResult();
        }
        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>( _iCarDal.GetAll(),Messages.CarsListed);
        }

        public IDataResult<List<Car>> GetById(int id)
        {
            
            return new SuccessDataResult<List<Car>>( _iCarDal.GetAll(p=>p.Id == id));

        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>( _iCarDal.GetCarDetails());
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_iCarDal.GetAll(p => p.BrandId == id));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_iCarDal.GetAll(p => p.ColorId == id));
        }

        public IResult Update(Car car)
        {
            _iCarDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }
    }
}
