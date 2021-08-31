using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
    //.NETcore biliyorum senın bir IoC yapılandırman var ama ben onu değilde burayı kullanmak ıstıyorum demem lazım!
    //Bunun için WebApı ye gel ve program.cs i aç
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            //SingleInstance:Data tutmuyor.Datanın kendisini tutmuyor.Sadece operasyon çağırma anlamında.
            //biri senden IProductService isterse ona bir tane ProductManager ver.
            //webapi--startup içerisindeki services.AddSingleton<IProductService,ProductManager>();
            //karşılık geliyor.
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();
        }
    }
}
