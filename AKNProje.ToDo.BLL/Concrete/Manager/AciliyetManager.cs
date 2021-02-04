using AKNProje.ToDo.BLL.Interface;
using AKNProje.ToDo.DAL.Concrete.EntityFrameworkcore.Repositories;
using AKNProje.ToDo.DAL.Interface;
using AKNProje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AKNProje.ToDo.BLL.Concrete.Manager
{
    public class AciliyetManager : IAciliyetService
    {
        private readonly IAciliyetDAL _aciliyetDAL;
        public AciliyetManager(IAciliyetDAL aciliyetDAL)
        {
            _aciliyetDAL = aciliyetDAL;
        }
        public List<Aciliyet> GetirHepsi()
        {
            return _aciliyetDAL.GetirHepsi();
        }

        public Aciliyet GetirIdile(int id)
        {
            return _aciliyetDAL.GetirIdile(id);
        }

        public void Güncelle(Aciliyet tablo)
        {
            _aciliyetDAL.Güncelle(tablo);
        }

        public void Kaydet(Aciliyet tablo)
        {
            _aciliyetDAL.Kaydet(tablo);
        }

        public void Sil(Aciliyet tablo)
        {
            _aciliyetDAL.Sil(tablo);
        }
    }
}
