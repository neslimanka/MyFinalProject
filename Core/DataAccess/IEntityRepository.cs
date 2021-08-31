using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //T bir refernas tipi olmalı ve T ya Ientity olabilir yada Ientity den implemente olan birşeydir.
    //T çalışacağım tip
    //new(): new'lenebilir olmalı. Yani IEntity'i implemente olanları kulakabileyim yalnızca
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        //Bu yukarıdaki yapı bizim ;
        //Ex:product.GetAll(p=>p.CategoryId==2); gibi filtreler yazabilmemizi sağlıyor.
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
