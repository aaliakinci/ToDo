using AKNProje.ToDo.BLL.Interface;
using AKNProje.ToDo.DAL.Concrete.EntityFrameworkcore.Repositories;
using AKNProje.ToDo.DAL.Interface;
using AKNProje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AKNProje.ToDo.BLL.Concrete.Manager
{
    public class ReportManager : IReportService
    {
        private readonly IReportDAL _reportDal;
        public ReportManager(IReportDAL reportDal)
        {
            _reportDal = reportDal;
        }
        public List<Report> GetAll()
        {
            return _reportDal.GetAll();
        }

        public Report GetById(int id)
        {
            return _reportDal.GetById(id);
        }

        public Report GetJobsWithReportAndUrgencyById(int id)
        {
            return _reportDal.GetJobsWithReportAndUrgencyById(id);
        }

        public void Update(Report tablo)
        {
            _reportDal.Update(tablo); 
        }

        public void Save(Report tablo)
        {
            _reportDal.Save(tablo);
        }

        public void Delete(Report tablo)
        {
            _reportDal.Delete(tablo);
        }
    }
}
