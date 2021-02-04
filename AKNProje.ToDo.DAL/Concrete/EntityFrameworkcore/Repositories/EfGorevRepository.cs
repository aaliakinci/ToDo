using AKNProje.ToDo.DAL.Concrete.EntityFrameworkcore.Contexts;
using AKNProje.ToDo.DAL.Interface;
using AKNProje.ToDo.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AKNProje.ToDo.DAL.Concrete.EntityFrameworkcore.Repositories
{
    public class EfGorevRepository : EfGenericRepository<Gorev>, IGorevDAL
    {
        public List<Gorev> GetGorevleriwithAllColumns()
        {
            using (var context = new ToDoContext())
            {
               return context.Gorevler.Include(x => x.Aciliyet).Include(x=>x.Rapor).Include(x=>x.AppUser).Where(x => !x.Durum).OrderByDescending(x => x.OlusturulmaTarihi).ToList();
            }

            
        }

        public Gorev GetGorevwithAciliyetandID(int id)
        {
            using (var context = new ToDoContext())
            {
                return context.Gorevler.Include(x => x.Aciliyet).FirstOrDefault(x => !x.Durum && x.ID == id);
            }

        }

        public List<Gorev> GetGorevwithAppUserID(int appUserId)
        {
            using (var context = new ToDoContext())
            {
                return context.Gorevler.Where(x => x.AppUserId == appUserId).ToList();
            }
        }

        public Gorev GetirGorevRaporlarile(int id)
        {
            using (var context = new ToDoContext())
            {
                return context.Gorevler.Include(x => x.AppUser).Include(x => x.Rapor).Where(x => x.ID == id).FirstOrDefault();
            }
        }
    }
}
