using AKNProje.ToDo.DAL.Concrete.EntityFrameworkcore.Contexts;
using AKNProje.ToDo.DAL.Interface;
using AKNProje.ToDo.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace AKNProje.ToDo.DAL.Concrete.EntityFrameworkcore.Repositories
{
    public class EfGenericRepository<Tablo> : IGenericDAL<Tablo> where Tablo : class, ITablo, new()
    {
        public List<Tablo> GetAll()
        {
            using (var context = new ToDoContext())
            {
                return context.Set<Tablo>().ToList();
            }
        }

        public Tablo GetById(int id)
        {
            using (var context = new ToDoContext())
            {
                return context.Set<Tablo>().Find(id);
            }
        }

        public void Update(Tablo tablo)
        {
            using (var context = new ToDoContext())
            {
                context.Entry(tablo).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Save(Tablo tablo)
        {
            using (var context = new ToDoContext())
            {
                context.Entry(tablo).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Tablo tablo)
        {
            using var context = new ToDoContext();
            context.Entry(tablo).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            context.SaveChanges();
        }

        
    }
}
