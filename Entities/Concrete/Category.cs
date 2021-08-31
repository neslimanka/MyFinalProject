using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    // Çıplak class kalmasın: Bu ne demek ?Eğer ki bir class herhangı bir inherit veya implementasyon almıyorsa anla ki ilerde problem yaşayacaksın
    //Proje buyuyunce burda problem yasanma ıhtımali yuksek.Biz bu varlıklarımzıı işaretleme eğilimine gireriz.yani gruplama eğilimine gideriz.
    //nedir bu gruplama? consrete klasorundek sınıflar bir veri tabanı tablosundaki verilere karşılık geliyor.
    public class Category: IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
