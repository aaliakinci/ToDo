﻿using AKNProje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AKNProje.ToDo.DAL.Interface
{
    public interface IReportDAL :IGenericDAL<Report>
    {
        Report GetJobsWithReportAndUrgencyById(int id);
    }
}
