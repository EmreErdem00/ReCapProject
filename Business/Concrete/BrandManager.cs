using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{

    public class BrandManager : IBrandService
    {
        IBrandDal _iBrandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _iBrandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            _iBrandDal.Add(brand);
            Console.WriteLine(brand.Id + " numaralı brand başarıyla eklendi.");
        }

        public void Delete(Brand brand)
        {
            _iBrandDal.Delete(brand);
            Console.WriteLine(brand.Id + " numaralı brand başarıyla silindi.");
        }

        public List<Brand> GetAll()
        {
           return _iBrandDal.GetAll();
        }

        public void Update(Brand brand)
        {
            _iBrandDal.Update(brand);
            Console.WriteLine(brand.Id + " numaralı brand başarıyla güncellendi.");
        }
    }
}
