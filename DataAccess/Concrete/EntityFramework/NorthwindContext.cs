using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Context: Db taboları ile proje classlarını bağlıyoruz.
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //projem hangi veritabanı ile ilişkiliğini belittiğim yer.
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true"); //dql server kullanıcagız. O zaman sql servere nasıl bağlanacagımı belitmem gerek.
            //çift tırnak içerisinde belirtiyoruz.Norma bir projede bir genelde IP göruruz.ama kucuk proje oldgu ıcın kendımız 
            //yazacağız.
        }
        //Context hangi veritabanına bağlanacağını buldu .
        //peki diyor ki benim hangi class ım hangi tabloya karşılık geliyor.
        public DbSet<Product> Products { get; set; } //bu şekilde belitiyoruz.
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
