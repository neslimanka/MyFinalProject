using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace ConsoleUI
{
    internal class InMemoryProductDal : IProductDal
    {
        public void Add(Product product)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new System.NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            throw new System.NotImplementedException();
        }

        public List<ProductDatailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new System.NotImplementedException();
        }
    }
}