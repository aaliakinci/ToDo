using AKNProje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AKNProje.ToDo.BLL.Interface
{
    public interface IJobService : IGenericService<Job>
    {
        List<Job> GetJobsWithAllColumns();
        Job GetJobsWithUrgencyByID(int id);
        List<Job> GetJobsWithAppUserID(int appUserId);
        List<Job> GetJobsWithAllColumns(Expression<Func<Job, bool>> filter);

        Job GetJobsWithReport(int id);
    }
}
