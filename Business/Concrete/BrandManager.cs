﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            return new SuccessResult(Messages.BrandAdded);
        }

        public IResult Delete(Brand brand)
        {
            return new SuccessResult(Messages.BrandDeleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(), Messages.BrandsListed);
        }

        public IDataResult<List<Brand>> GetByBrandId(int id)
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(bra => bra.BrandId == id));
        }

        public IDataResult<List<Brand>> GetBrandsByBrandNAme(string BrandName)
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(bn => bn.BrandName == BrandName));
        }

        public IResult Update(Brand brand)
        {
            return new SuccessResult(Messages.BrandUpdated);
        }
    }
}
