using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Context: Db taboları ile proje classlarını bağlıyoruz.
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //projem hangi veritabanı ile ilişkiliğini belittiim yer.
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true"); //dql server kullanıcagız. O zaman sql servere nasıl bağlanacagımı belitmem gerek.
            //çift tırnak içerisinde belirtiyoruz.Norma bir projede bir genelde IP göruruz.ama kucuk proje oldgu ıcın kendımız 
            //yazacağız.
        }
    }
}
