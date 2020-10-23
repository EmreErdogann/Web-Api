using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAcces.Abstract
{
    public interface IGenericDal<T> where T:class,new()
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Remove(T entity);
        void Update(T entity);
    }
}
