﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
     

    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {
            //AOP: biz bütün metodlarımızı loglamak istiyoruz.Normalde ILoggerService.Log() gibi bişey 
            //denerim.onun yerine ben şunu yapıcam :

            //[LogAspect]-->Git bu metodu log la.
            //[Validate]-->Bunu doğrula
            //metot(){

            //}
            //AOP : bir metodun önunde ,bir metodun sonunda ,bir metot hata verdiğinde çalışan kod parçacıklarını
            //biz AOP mimarisi ile yazıyoruz.Yani business in içinde business yazılır.
            //bu şekilde bir altyapı oluşturulabilir.
            if (product.ProductName.Length < 2)
            {
                return new ErrorResult(Messages.ProductNameInvalid);
            }

            _productDal.Add(product);
           
            return new SuccessResult(Messages.ProductAdded);
        }

        public IDataResult<List<Product>> GetAll()
        {
            //if (DateTime.Now.Hour == 22)
            //{
            //    return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            //}
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(),Messages.ProductsListed);
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            return  new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.CategoryId == id));
        }

        public IDataResult<Product> GetById(int productId)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductId == productId));
        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max));
        }

        public IDataResult<List<ProductDatailDto>> GetProductDetails()
        {
            return new SuccessDataResult<List<ProductDatailDto>>(_productDal.GetProductDetails());
        }
    }
  
}
