using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            Car car5 = new Car();
            car5.Id = 5;
            car5.BrandId = 2;
            car5.ColorId = 2;
            car5.ModelYear = "2020";
            car5.Description = "Lpg and used 60000 km";
            car5.DailyPrice = 150500;

            

            foreach ( var car in carManager.GetAll())
            {
                Console.WriteLine("Car Id: " + car.Id);
                Console.WriteLine("Marka Id: " + car.BrandId);
                Console.WriteLine("Color Id: " + car.ColorId);
                Console.WriteLine("Model Year:" + car.ModelYear);
                Console.WriteLine("Daily Price: " + car.DailyPrice);
                Console.WriteLine("Description: " + car.Description);
                Console.WriteLine("--------------------");

            }

            carManager.Add(car5);
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Car Id: " + car.Id);
                Console.WriteLine("Marka Id: " + car.BrandId);
                Console.WriteLine("Color Id: " + car.ColorId);
                Console.WriteLine("Model Year:" + car.ModelYear);
                Console.WriteLine("Daily Price: " + car.DailyPrice);
                Console.WriteLine("Description: " + car.Description);
                Console.WriteLine("--------------------");

            }
            foreach (var car in carManager.GetById(2))
            {
                Console.WriteLine("Car Id: " + car.Id);
                Console.WriteLine("Marka Id: " + car.BrandId);
                Console.WriteLine("Color Id: " + car.ColorId);
                Console.WriteLine("Model Year:" + car.ModelYear);
                Console.WriteLine("Daily Price: " + car.DailyPrice);
                Console.WriteLine("Description: " + car.Description);
                Console.WriteLine("--------------------");

            }


            carManager.Delete(1);

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Car Id: " + car.Id);
                Console.WriteLine("Brand Id: " + car.BrandId);
                Console.WriteLine("Color Id: " + car.ColorId);
                Console.WriteLine("Model Year:" + car.ModelYear);
                Console.WriteLine("Daily Price: " + car.DailyPrice);
                Console.WriteLine("Description: " + car.Description);
                Console.WriteLine("--------------------");

            }

            carManager.Update(new Car{ Id = 2, BrandId = 2, ColorId = 2, ModelYear = "2020", Description = "Nice car", DailyPrice = 600000});

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Car Id: " + car.Id);
                Console.WriteLine("Brand Id: " + car.BrandId);
                Console.WriteLine("Color Id: " + car.ColorId);
                Console.WriteLine("Model Year:" + car.ModelYear);
                Console.WriteLine("Daily Price: " + car.DailyPrice);
                Console.WriteLine("Description: " + car.Description);
                Console.WriteLine("--------------------");

            }
            Console.ReadKey();

            
        }
    }
}
