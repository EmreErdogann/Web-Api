using System;
using System.Collections.Generic;
using System.Text;

namespace Busines.Abstract
{
    public interface IGenericService<T> where T:class,new()
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Remove(T entity);
        void Update(T entity);
    }
}
