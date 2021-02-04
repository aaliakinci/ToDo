using AKNProje.ToDo.BLL.Interface;
using AKNProje.ToDo.DAL.Concrete.EntityFrameworkcore.Repositories;
using AKNProje.ToDo.DAL.Interface;
using AKNProje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AKNProje.ToDo.BLL.Concrete.Manager
{
    public class RaporManager : IRaporService
    {
        private readonly IRaporDAL _raporDAL;
        public RaporManager(IRaporDAL raporDAL)
        {
            _raporDAL = raporDAL;
        }
        public List<Rapor> GetirHepsi()
        {
            return _raporDAL.GetirHepsi();
        }

        public Rapor GetirIdile(int id)
        {
            return _raporDAL.GetirIdile(id);
        }

        public void Güncelle(Rapor tablo)
        {
            _raporDAL.Güncelle(tablo); 
        }

        public void Kaydet(Rapor tablo)
        {
            _raporDAL.Kaydet(tablo);
        }

        public void Sil(Rapor tablo)
        {
            _raporDAL.Sil(tablo);
        }
    }
}
