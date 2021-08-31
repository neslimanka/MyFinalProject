using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    public interface IDataResult<T> : IResult
    //IDataResult<generic>, hangi data tipiyle tanışacagını benım özel olarak söylemem gerekiyo
    //Çünkü her metot baska birşey bekliyor. Biri ürün döndürüyo ,biri ürün lstesi döndürüyo,biri ategory döndürüyor.
    //o yuzden ne olacagını burada generic ile belirliyorum.
    {
        T Data { get; }

    }
    //interface , interface i implemente ederse implemente edilen interface in elemanarı zaten burada.
}
