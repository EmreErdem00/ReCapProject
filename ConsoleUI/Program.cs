using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EFCarDal());
            BrandManager brandManager = new BrandManager(new EFBrandDal());
            ColorManager colorManager = new ColorManager(new EFColorDal());

            //brandManager.Add(new Brand {Name = "Ford"});
            //brandManager.Update(new Brand{Id=4, Name="Peugeot" });
            //brandManager.Update(new Brand { Id = 5, Name = "Fiat" });



            //colorManager.Update(
            //new Color{Id=6,Name="Gri"});

            //carManager.Update(new Car {Id=3, BrandId=2,ColorId=4,Name="Duster" ,DailyPrice=108000, Description="Yeni araç 4x2", ModelYear="2021" });
            //carManager.Add(new Car {

            //    ColorId = 1,
            //    BrandId = 3,
            //    Name = "Fiesta",
            //    ModelYear = "2012",
            //    Description = "On numara araç",
            //    DailyPrice = 120000
            //});


            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Name + " / "+ item.ModelYear);
            }

            Console.ReadKey();

            
        }
    }
}
