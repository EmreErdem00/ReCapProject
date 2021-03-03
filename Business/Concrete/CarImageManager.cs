using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.FileHelper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _iCarImageDal;
        public CarImageManager(ICarImageDal carImageDal)
        {
            _iCarImageDal = carImageDal;
        }
        public IResult Add(IFormFile file,CarImage carImage)
        {
            IResult result = BusinessRules.Run(CheckNumberOfCarImage(carImage.CarId));
            if (result != null)
            {
                return result;
            }
           carImage.ImagePath = FileHelper.AddAsync(file);
            carImage.Date = DateTime.Now;
            _iCarImageDal.Add(carImage);

            return new SuccessResult(Messages.CarImageAdded);
        }
        

        public IResult Delete(CarImage carImage)
        {
            IResult result = BusinessRules.Run(FileHelper.DeleteAsync(_iCarImageDal.GetById(p =>p.Id == carImage.Id).ImagePath));

            if (result != null)
            {
                return result;
            }
           
            _iCarImageDal.Delete(carImage);
            return new SuccessResult(Messages.CarImageDeleted);
        }

       

        public IDataResult<CarImage> GetById(int Id)
        {
            
            return new SuccessDataResult<CarImage>(_iCarImageDal.Get(p => p.Id == Id));
           
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            
            return new SuccessDataResult<List<CarImage>>(_iCarImageDal.GetAll(),Messages.CarAdded);
        }

        public IDataResult<List<CarImage>> GetCarById(int carId)
        {
            return new SuccessDataResult<List<CarImage>>(CheckIfCarImageExists(carId));
        }

        public IResult Update(IFormFile file, CarImage carImage)
        {
            carImage.ImagePath = FileHelper.UpdateAsync(_iCarImageDal.GetAll(p=>p.Id==carImage.Id).ToString(), file);
            carImage.Date = DateTime.Now;
            _iCarImageDal.Update(carImage);
            return new SuccessResult(Messages.CarImageUpdated);
        }

        private IResult CheckNumberOfCarImage(int carId)
        {
            var result = _iCarImageDal.GetAll(p => p.CarId == carId).Count;


            if(result > 5)
            {
                return new ErrorResult(Messages.NoMoreImage);
            }
            return new SuccessResult();
        }

        private List<CarImage> CheckIfCarImageExists(int carId)
        {
            
                string path = Environment.CurrentDirectory + @"\wwwroot\Images\default.jpg";
                var result = _iCarImageDal.GetAll(p => p.CarId == carId).Any();
                if (!result)
                {
               
                return  new List<CarImage>{ new CarImage { CarId = carId, ImagePath = path, Date = DateTime.Now } };
                }
                
                return _iCarImageDal.GetAll(p=>p.CarId==carId);
        }




    }
}
