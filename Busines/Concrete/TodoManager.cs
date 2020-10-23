using Busines.Abstract;
using DataAcces.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busines.Concrete
{
    public class TodoManager : ITodoService
    {
        private readonly ITodoDal _todoDal;
        public TodoManager(ITodoDal todoDal)
        {
            _todoDal = todoDal;
        }
        public void Add(Todo entity)
        {
            _todoDal.Add(entity);
        }

        public IEnumerable<Todo> GetAll()
        {
            return _todoDal.GetAll();
        }

        public Todo GetById(int id)
        {
           return _todoDal.GetById(id);

        }

        public void Remove(Todo entity)
        {
            _todoDal.Remove(entity);
        }

        public void Update(Todo entity)
        {
            _todoDal.Update(entity);
        }
    }
}
