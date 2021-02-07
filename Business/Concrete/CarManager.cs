using Business.Abstract;
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

        public void Add(Car car)
        {
           _iCarDal.Add(car);
            Console.WriteLine(car.Id +" numaralı araç başarıyla eklendi.");
        }

        public void Delete(Car car)
        {
            _iCarDal.Delete(car);
            Console.WriteLine(car.Id + "numaralı araç başarıyla silindi.");
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _iCarDal.GetAll();
        }

        public List<Car> GetById(int id)
        {
            Console.WriteLine(id + " numaralı araç gösteriliyor.");
            return _iCarDal.GetAll(p=>p.Id == id);

        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _iCarDal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _iCarDal.GetAll(p => p.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _iCarDal.GetAll(p => p.ColorId == id);
        }

        public void Update(Car car)
        {
            _iCarDal.Update(car);
            Console.WriteLine(car.Id +" numaralı araç başarıyla güncellendi.");
        }
    }
}
