using AKNProje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AKNProje.ToDo.DAL.Interface
{
    public interface IJobDAL :IGenericDAL<Job>
    {
        List<Job> GetJobsWithAllColumns();
        List<Job> GetJobsWithAllColumns(Expression<Func<Job,bool>>filter);
        Job GetJobsWithUrgencyByID(int id);
        List<Job> GetJobsWithAppUserID(int appUserId);
        Job GetJobsWithReport(int id);
    }
}
