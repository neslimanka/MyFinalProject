using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products; //global değişken
        public InMemoryProductDal()
        {
            //veritabanıdan gelecek olan bilgiler 
            _products = new List<Product> {
            new Product
                {
                    ProductId =1,
                    CategoryId =1,
                    ProductName ="Bardak",
                    UnitPrice =15,
                    UnitsInStock =15
                },
            new Product
            {
                ProductId = 2,
                CategoryId = 1,
                ProductName = "Kamera",
                UnitPrice = 15,
                UnitsInStock = 15

            },
            new Product
        {
                    ProductId =3,
                    CategoryId =2,
                    ProductName ="Telefon",
                    UnitPrice =500,
                    UnitsInStock =3
        },
            new Product
           {
                    ProductId =4,
                    CategoryId =2,
                    ProductName ="Klavye",
                    UnitPrice =500,
                    UnitsInStock =15
            },
            new Product
          {
                    ProductId =5,
                    CategoryId =2,
                    ProductName ="Fare",
                    UnitPrice =1500,
                    UnitsInStock =69
           },

            };
        }
        public void Add(Product entity)
        {
            _products.Add(entity);
        }

        public void Delete(Product entity)
        {
            //LINQ ne işe yarıyor? C# ı diğer dillerden daha güçlü hale getiren kullanımlardan bir tanesidir.
            //Language Integrated Query - linq ile sql bazlı kodları giltreleyebiliyoruz. 
            Product productToDelete = null;
            //foreach (var item in _products)
            //{
            //    if (product.ProductId == product.ProductId)
            //    {
            //        productToDelete = item; 
            //    }
            //} bu kodu linq ile çok kısa yazabiliyoruz.
            productToDelete = _products.SingleOrDefault(p => p.ProductId == entity.ProductId);
            //Bunun yerine FirstOrDefault veya First de kullansak olur.
            //SİngleOrDefault : tek bir eleman bulmaya yarar.Bu biizm yerimize _products ı tek tek dolaşmaya yarar
            _products.Remove(entity);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            return _products;
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == entity.ProductId);
            productToUpdate.ProductName = entity.ProductName;
            productToUpdate.CategoryId = entity.CategoryId;
            productToUpdate.UnitPrice = entity.UnitPrice;
            productToUpdate.UnitsInStock = entity.UnitsInStock;
        }
    }
}
