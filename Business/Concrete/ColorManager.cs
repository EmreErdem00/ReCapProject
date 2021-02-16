using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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
        public IResult Add(Color color)
        {
            _iColorDal.Add(color);
            return new SuccessResult();
        }

       

        public IResult Delete(Color color)
        {
            
            _iColorDal.Delete(color);
            return new SuccessResult();
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>> (_iColorDal.GetAll());
        }
        public IResult Update(Color color)
        {
            _iColorDal.Update(color);
            return new SuccessResult();
        }

     
    }
}
