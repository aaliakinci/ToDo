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
        public List<Tablo> GetirHepsi()
        {
            using (var context = new ToDoContext())
            {
                return context.Set<Tablo>().ToList();
            }
        }

        public Tablo GetirIdile(int id)
        {
            using (var context = new ToDoContext())
            {
                return context.Set<Tablo>().Find(id);
            }
        }

        public void Güncelle(Tablo tablo)
        {
            using (var context = new ToDoContext())
            {
                context.Entry(tablo).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Kaydet(Tablo tablo)
        {
            using (var context = new ToDoContext())
            {
                context.Entry(tablo).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Sil(Tablo tablo)
        {
            using var context = new ToDoContext();
            context.Entry(tablo).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            context.SaveChanges();
        }
    }
}
