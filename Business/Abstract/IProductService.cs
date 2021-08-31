using Core.Utilities;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        //iş katmanında kullanacağımız servis elemanlarımız
        IDataResult<List<Product>> GetAll();//Ürün Listesi Döndürür
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IDataResult<Product> GetById(int productId);

        IResult Add(Product product);
    }
}
