using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Product:IEntity // public bu class a diğer katmanlar da ulaşabilsin demektir!Çünkü dataAccsess ürünü ekleyecek,Business ürünü kontrol edecek
                         //console urunu gösterecek. Yani bu üç katmanda kullanılcak
                         //bir classın defaultu "internal" dır.internal demek sadece entities erişebilir demek.
    {

        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; } // small int 
        public decimal UnitPrice { get; set; }


    }
}
