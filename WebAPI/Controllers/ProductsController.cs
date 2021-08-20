using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]



    public class ProductsController : ControllerBase
    {

        IProductService _productService;

        //Loosely coupled
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public List<Product> Get()
        {
            //Dependency chain--bağımlılık zinciri
           
            var result = _productService.GetAll();
            return result.Data;
        }
    }
     
            
    }

//injetcion
//constructur da erişim yok .
//IoC Container --Inversion of control:Bellekte bir liste oldugunu düşün, bu listenin içerisine new Produtmanager(),
//New efProduct Dal() vb. içeriisne bu tarz referanslar koyayım.Sonra kim ihtiyac duyuyorsa onu ona verelim.Peki bunu nasıl
//yapıyoruz. Solution explorera gel.Web API içerisinde "startup " aç.

//public void ConfigureServices(IServiceCollection services)
//{
//    services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
//    services.AddSingleton<IProductService, ProductManager>();
//      Bana arka planda bir servis olustur.
//      Ben diyorum ki IoC ye , birisi senden IProductServis isterse ona arka planda bir tane ProductManager oluştur 
//      onu ver 

//}

    //Singleton:tum bellekte 1 tane ProductManager oluşturuyo  isterse bie milyon client gelsin hepsine aynı instance i veriyor.
    //Ama singleton ı ne zaman kullanacagız?İçeriisnde data tutmuyorsak . mesela bir sepet tutuyorsak o sepetide manager da tutuyorsak 
    //bu sefer herkesin sepeti birbirine girer.Biri sepete urun ekleyınce herkese eklenmıs olur ,cıkarınca herkesten cıkarılmıs olur.
    //