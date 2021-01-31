﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
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

        public void Delete(int carId)
        {
            _iCarDal.Delete(carId);
            Console.WriteLine(carId + "numaralı araç başarıyla silindi.");
        }

        public List<Car> GetAll()
        {
            return _iCarDal.GetAll();
        }

        public List<Car> GetById(int id)
        {
            Console.WriteLine(id + " numaralı araç gösteriliyor.");
            return _iCarDal.GetById(id);

        }

        public void Update(Car car)
        {
            _iCarDal.Update(car);
            Console.WriteLine(car.Id +" numaralı araç başarıyla güncellendi.");
        }
    }
}