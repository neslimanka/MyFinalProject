using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{

    //Solıd
    //Open Closed Principle--yaptığın yazılıma yenı bir özellik ekliyorsan mevcuttaki kodlara dokunamazsın.
    class Program
    {
        static void Main(string[] args)
        {

            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var item in productManager.GetByUnitPrice(50,100))
            {
                Console.WriteLine(item.ProductName);
            }
            Console.ReadLine();
        }
    }
}
