using DataAcces.Abstract;
using DataAcces.Concrete.EntityFreamwork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAcces.Concrete.Repository
{
    public class EfGenericRepository<T> : IGenericDal<T> where T : class, new()
    {
        public void Add(T entity)
        {
            using (var context = new Context())
            {
                var added = context.Entry(entity);
                added.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public IEnumerable<T> GetAll()
        {
            using (var context = new Context())
            {
                return context.Set<T>().ToList();
            }
        }

        public T GetById(int id)
        {
            using (var context = new Context())
            {
                return context.Set<T>().Find(id);
            }
        }

        public void Remove(T entity)
        {
            using (var context = new Context())
            {
                var deleted = context.Entry(entity);
                deleted.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void Update(T entity)
        {
            using (var context = new Context())
            {
                var updated = context.Entry(entity);
                updated.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
