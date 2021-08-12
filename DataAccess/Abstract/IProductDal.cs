using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //Product ile ilgili veritabanında yapacagım operasyonları içeren interface.Operasyon(sil,ekle,güncelle vb)
   /*public interface IProductDal*/ //NOT:interface in operasyonları public ama kendısı public değildir!
    //{
        //List<Product> GetAll(); //Baska bir katmanı kullanmak istiyorsak referans veririz!Burada Entities te product a ihtiyacımız var.
        ////Bunu yaptığımızda otomatik olarak dependicies e eklenecektir.Yada dependicies sağ tık add references ve entities seçilir
        //void Add(Product product);
        //void Delete(Product product);
        //void Update(Product product);
        //List<Product> GetAllByCategory(int categoryId);
    //}
    public interface IProductDal:IEntityRepository<Product> //çalışma tipi Product
        //Ben burada IEntityRepository ı product için yapılandırıdm

    {
        List<ProductDatailDto> GetProductDetails();

    }
}
