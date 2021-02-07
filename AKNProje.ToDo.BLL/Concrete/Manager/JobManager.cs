using AKNProje.ToDo.BLL.Interface;
using AKNProje.ToDo.DAL.Concrete.EntityFrameworkcore.Repositories;
using AKNProje.ToDo.DAL.Interface;
using AKNProje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AKNProje.ToDo.BLL.Concrete.Manager
{
    public class JobManager : IJobService
    {
        private readonly IJobDAL _jobDal;
        public JobManager(IJobDAL jobDAL)
        {
            _jobDal = jobDAL;
        }

        public List<Job> GetJobsWithAllColumns()
        {
            return _jobDal.GetJobsWithAllColumns();
        }

        public List<Job> GetJobsWithAllColumns(Expression<Func<Job, bool>> filter)
        {
            return _jobDal.GetJobsWithAllColumns(filter);
        }

        public Job GetJobsWithUrgencyByID(int id)
        {
            return _jobDal.GetJobsWithUrgencyByID(id);
        }

        public List<Job> GetJobsWithAppUserID(int appUserId)
        {
            return _jobDal.GetJobsWithAppUserID(appUserId);
        }

        public Job GetJobsWithReport(int id)
        {
            return _jobDal.GetJobsWithReport(id);
        }

        public List<Job> GetAll()
        {
            return _jobDal.GetAll();
        }

        public Job GetById(int id)
        {
            return _jobDal.GetById(id);
        }

        public void Update(Job tablo)
        {
            _jobDal.Update(tablo);
        }

        public void Save(Job tablo)
        {
            _jobDal.Save(tablo);
        }

        public void Delete(Job tablo)
        {
            _jobDal.Delete(tablo);
        }
    }
}
