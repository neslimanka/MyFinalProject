using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{

    //Solıd
    //Open Closed Principle--yaptığın yazılıma yenı bir özellik ekliyorsan mevcuttaki kodlara dokunamazsın.
   public class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
           // CategoryTest();

        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var item in categoryManager.GetAll())
            {
                Console.WriteLine(item.CategoryName);
                Console.ReadLine();

            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var item in productManager.GetProductDetails())
            {
                Console.WriteLine(item.ProductName+ "/" + item.CategoryName);
                Console.ReadLine();

            }
        }

        
    }

    
}
