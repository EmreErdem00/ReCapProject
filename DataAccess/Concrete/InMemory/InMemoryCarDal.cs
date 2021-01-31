using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> cars;

        public InMemoryCarDal()
        {
            cars = new List<Car>
            {
                new Car {Id=1,BrandId=1,ColorId=1,DailyPrice=300000, Description="dsg fuel", ModelYear="2021" },
                new Car {Id=2,BrandId=2,ColorId=3,DailyPrice=550400, Description="v8 turbo fuel", ModelYear="2020" },
                new Car {Id=3,BrandId=3,ColorId=2,DailyPrice=250000, Description="cvt fuel", ModelYear="2019" },
                new Car {Id=4,BrandId=4,ColorId=1,DailyPrice=130200, Description="1.5 diesel", ModelYear="2017" }


            };


        }
        

        
       
        public void Add(Car car)
        {
            cars.Add(car);
        }

        public void Delete(int carId)
        {
            Car deleteCarFromId = cars.SingleOrDefault(p => p.Id == carId);
            cars.Remove(deleteCarFromId);
        }

        public List<Car> GetAll()
        {
            return cars;
        }

        public List<Car> GetById(int id)
        {
            return cars.Where(p=> p.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car updateCarFromId = cars.SingleOrDefault(p => p.Id == car.Id);
            updateCarFromId.Id = car.Id;
            updateCarFromId.BrandId = car.BrandId;
            updateCarFromId.ColorId = car.ColorId;
            updateCarFromId.Description = car.Description;
            
            
        }
    }
}
