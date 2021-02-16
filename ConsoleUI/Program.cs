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
            UserManager userManager = new UserManager(new EFUserDal());
            CustomerManager customerManager = new CustomerManager(new EFCustomerDal());
            RentalManager rentalManager = new RentalManager(new EFRentalDal());

            //var result1 =userManager.Add(new User {FirstName = "Emel", LastName = "Erdem", Email = "nida.erdem3875@gmail.com", Password = "123.Nida" });
            ////customerManager.Add(new Customer { UserId=1, CompanyName = "hey Ajans" });
            //if (result1.Success == true)
            //{
            //    Console.WriteLine(result1.Message);
            //}

            //var result = customerManager.Add(new Customer { UserId = 3, CompanyName = "Havalı Ajans" });

            //if(result.Success == true)
            //{
            //    Console.WriteLine(result.Message);
            //}


            var result3 = carManager.Add(new Car
            {


               BrandId=2,
               ColorId=3,
               DailyPrice=10000,
               Description="süper araç",
               ModelYear="2012",
               Name ="leon"
               
            });
            Console.WriteLine(result3.Message);


            //foreach (var item in carManager.GetCarDetails().Data)
            //{
            //    Console.WriteLine(item.CarName + " / " + item.BrandName + " / " + item.ColorName + " / " + item.DailyPrice);
            //}

            Console.ReadKey();

            
        }
    }
}
