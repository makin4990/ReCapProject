using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class ColorManager:IColorService
    {
         IColorDal _colorDal;

         public ColorManager(IColorDal colorDal)
         {
             _colorDal = colorDal;
         }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccesDataResult<List<Color>>(_colorDal.GetAll());
        }

        public IDataResult<Color> GetById(int colorId)
        {
            return new SuccesDataResult<Color>(_colorDal.Get(p => p.Id == colorId));
            
        }

        public IResult Add(Color color)
        {
            return new SuccessResult(Messages.CarAdded);
            _colorDal.Add(color);
        }
    }
}
