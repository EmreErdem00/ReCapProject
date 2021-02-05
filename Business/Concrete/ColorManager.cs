using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _iColorDal;
        public ColorManager(IColorDal colorDal)
        {
            _iColorDal = colorDal;
        }
        public void Add(Color color)
        {
            _iColorDal.Add(color);
            Console.WriteLine(color.Id + " numaralı color başarıyla eklendi.");
        }

       

        public void Delete(Color color)
        {
            
            _iColorDal.Delete(color);
            Console.WriteLine(color.Id + " numaralı color başarıyla silindi.");
        }

        public List<Color> GetAll()
        {
            return _iColorDal.GetAll();
        }
        public void Update(Color color)
        {
            _iColorDal.Update(color);
            Console.WriteLine(color.Id + " numaralı color başarıyla güncellendi.");
        }

     
    }
}
