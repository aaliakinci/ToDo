using AKNProje.ToDo.BLL.Interface;
using AKNProje.ToDo.DAL.Concrete.EntityFrameworkcore.Repositories;
using AKNProje.ToDo.DAL.Interface;
using AKNProje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AKNProje.ToDo.BLL.Concrete.Manager
{
    public class UrgencyManager : IUrgencyService
    {
        private readonly IUrgencyDAL _urgencyDAL;
        public UrgencyManager(IUrgencyDAL urgencyDAL)
        {
            _urgencyDAL = urgencyDAL;
        }
        public List<Urgency> GetAll()
        {
            return _urgencyDAL.GetAll();
        }

        public Urgency GetById(int id)
        {
            return _urgencyDAL.GetById(id);
        }

        public void Update(Urgency tablo)
        {
            _urgencyDAL.Update(tablo);
        }

        public void Save(Urgency tablo)
        {
            _urgencyDAL.Save(tablo);
        }

        public void Delete(Urgency tablo)
        {
            _urgencyDAL.Delete(tablo);
        }
    }
}
