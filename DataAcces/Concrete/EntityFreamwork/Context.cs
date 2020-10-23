using DataAcces.Abstract;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Concrete.EntityFreamwork
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=Emre; Database=Todo; Integrated Security=TRUE;");
        }
        public DbSet<Todo> Todos { get; set; }
    }
}
