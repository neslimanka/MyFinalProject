using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity ,new ()
        //T bir refernas tipi olmalı ve T ya Ientity olabilir yada Ientity den implemente olan birşeydir.
        //T çalışacağım tip
        //new(): new'lenebilir olmalı. Yani IEntity'i implemente olanları kulakabileyim yalnızca
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null );
        //Bu yukarıdaki yapı bizim ;
        //Ex:product.GetAll(p=>p.CategoryId==2); gibi filtreler yazabilmemizi ağlıyor.
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        

    }
}
