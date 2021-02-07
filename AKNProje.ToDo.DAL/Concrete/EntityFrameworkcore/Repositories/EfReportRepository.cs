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
    public class EfReportRepository : EfGenericRepository<Report>, IReportDAL
    {
        public Report GetJobsWithReportAndUrgencyById(int id)
        {
            using var context = new ToDoContext();
            return context.Reports.Include(x => x.Job).ThenInclude(x => x.Urgency).Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
