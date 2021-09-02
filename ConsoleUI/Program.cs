using Business.CCS;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {

        static void Main(string[] args)
        {
            ProductTest();
           // CategoryTest();
            Console.WriteLine("--------------------------------------------------------");

            Console.Read();
        }
        //private static void CategoryTest()
        //{
        //    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        //    foreach (var item in categoryManager.GetAll())
        //    {
        //        Console.WriteLine(item.CategoryName);
        //        Console.ReadLine();

        //    }
        //}

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(), new CategoryManager(new EfCategoryDal()));
            var result = productManager.GetProductDetails();
            if (result.Success == true)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.ProductName + "/" + item.CategoryName);
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            }
        }
}

