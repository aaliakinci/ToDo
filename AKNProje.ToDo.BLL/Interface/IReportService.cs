using AKNProje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AKNProje.ToDo.BLL.Interface
{
   public interface IReportService:IGenericService<Report>
    {
        Report GetJobsWithReportAndUrgencyById(int id);

    }
}
