using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Business.CCS;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities;
using Core.Utilities.Business;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        ICategoryService _categoryService;
       

        public ProductManager(IProductDal productDal,ICategoryService categoryService )
        {
            _productDal = productDal;
            _categoryService = categoryService;
            
        }

        [SecuredOperation("product.add")]
        [ValidationAspect(typeof(ProductValidator))]
        public IResult Add(Product product)
          {

           IResult result= BusinessRule.Run(CheckIfProductNameExists(product.ProductName),
                CheckIfProductCountofCategoryCorrect(product.CategoryId ));


            if (result != null)//kurala uymayan bir durum oluşmussa
            {
                return result;
            }
            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);

    

            //ValidationTool.Validate(new ProductValidator(), product);

            //AOP: biz bütün metodlarımızı loglamak istiyoruz.Normalde ILoggerService.Log() gibi bişey 
            //denerim.onun yerine ben şunu yapıcam :

            //[LogAspect]-->Git bu metodu log la.
            //[Validate]-->Bunu doğrula--Eklemeye çalıştıgımız product objesinin iş kurallarına dahil etmek
            //için yapısal olarak uygun olup olmadıgını kontrol etmeye doğrulama denir.

            //metot(){

            //}
            //AOP : bir metodun önunde ,bir metodun sonunda ,bir metot hata verdiğinde çalışan kod parçacıklarını
            //biz AOP mimarisi ile yazıyoruz.Yani business in içinde business yazılır.
            //bu şekilde bir altyapı oluşturulabilir.

            //

          

      
        }

        public IDataResult<List<Product>> GetAll()
        {
            if (DateTime.Now.Hour == 1)
            {
                return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(), Messages.ProductsListed);
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.CategoryId == id));
        }

        public IDataResult<Product> GetById(int productId)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductId == productId));
        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max));
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails());
        }

        [ValidationAspect(typeof(ProductValidator))]
        public IResult Update(Product product)
        {
            var result = _productDal.GetAll(p => p.CategoryId == product.CategoryId).Count;
            if (result >= 10)
            {
                return new ErrorResult(Messages.ProductCountOfCategoryError);
            }
            throw new NotImplementedException();
        }

        private IResult CheckIfProductCountofCategoryCorrect(int categoryId)
        {
            var result = _productDal.GetAll(p => p.CategoryId == categoryId).Count;
            if (result >= 10)
            {
                return new ErrorResult(Messages.ProductCountOfCategoryError);
            }
            return new SuccessResult();
        }

        private IResult CheckIfProductNameExists(string productName)
        {
            var result = _productDal.GetAll(p => p.ProductName == productName).Any();
            if (result)
            {
                return new ErrorResult(Messages.ProductNameAlreadyExists);
            }
            return new SuccessResult();
        }

    }
}
 