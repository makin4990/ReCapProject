using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
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

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public Color GetById(int colorId)
        {
            return _colorDal.Get(p => p.Id == colorId);
            
        }

        public void Add(Color color)
        {
            _colorDal.Add(color);
        }
    }
}
