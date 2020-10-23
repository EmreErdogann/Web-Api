using DataAcces.Abstract;
using DataAcces.Concrete.EntityFreamwork;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAcces.Concrete.Repository
{
    public class EfTodoRepository : EfGenericRepository<Todo>, ITodoDal
    {
       
    }
}
