using AKNProje.ToDo.DAL.Concrete.EntityFrameworkcore.Contexts;
using AKNProje.ToDo.DAL.Interface;
using AKNProje.ToDo.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace AKNProje.ToDo.DAL.Concrete.EntityFrameworkcore.Repositories
{
    public class EfJobRepository : EfGenericRepository<Job>, IJobDAL
    {
        public List<Job> GetJobsWithAllColumns()
        {
            using (var context = new ToDoContext())
            {
               return context.Jobs.Include(x => x.Urgency).Include(x=>x.Report).Include(x=>x.AppUser).Where(x => !x.Status).OrderByDescending(x => x.CreatedAt).ToList();
            }  
        }

        public List<Job> GetJobsWithAllColumns(Expression<Func<Job, bool>> filter)
        {
            using (var context = new ToDoContext())
            {
                return context.Jobs.Include(x => x.Urgency).Include(x => x.Report).Include(x => x.AppUser).Where(filter).OrderByDescending(x => x.CreatedAt).ToList();
            }
        }

        public Job GetJobsWithUrgencyByID(int id)
        {
            using (var context = new ToDoContext())
            {
                return context.Jobs.Include(x => x.Urgency).FirstOrDefault(x => !x.Status && x.ID == id);
            }

        }

        public List<Job> GetJobsWithAppUserID(int appUserId)
        {
            using (var context = new ToDoContext())
            {
                return context.Jobs.Where(x => x.AppUserId == appUserId).ToList();
            }
        }

        public Job GetJobsWithReport(int id)
        {
            using (var context = new ToDoContext())
            {
                return context.Jobs.Include(x => x.AppUser).Include(x => x.Report).Where(x => x.ID == id).FirstOrDefault();
            }
        }
    }
}
