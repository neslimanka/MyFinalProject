using System.Collections.Generic;
using DataAccess.Abstract;
using Entities.Concrete;

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

        public List<Product> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new System.NotImplementedException();
        }
    }
}