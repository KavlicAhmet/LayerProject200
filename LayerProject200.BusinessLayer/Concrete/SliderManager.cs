﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LayerProject200.BusinessLayer.Abstract;
using LayerProject200.DataAccessLayer.Abstract;
using LayerProject200.DataAccessLayer.EntiyFramework;
using LayerProject200.EntityLayer.Concrete;

namespace LayerProject200.BusinessLayer.Concrete
{
    public class SliderManager : ISliderService
    {
        private readonly ISliderDal _sliderDal;

        public SliderManager(ISliderDal sliderDal)
        {
            _sliderDal = sliderDal;
        }

        public void TDelete(int id)
        {
            _sliderDal.Delete(id);
        }

        public List<Slider> TGetAll()
        {
            return _sliderDal.GetAll();
        }

        public Slider TGetById(int id)
        {
            return _sliderDal.GetById(id);
        }

        public void TInsert(Slider entity)
        {
            _sliderDal.Insert(entity);
        }

        public void TUpdate(Slider entity)
        {
            _sliderDal.Update(entity);
        }
    }
}
