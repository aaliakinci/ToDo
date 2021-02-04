using AKNProje.ToDo.BLL.Interface;
using AKNProje.ToDo.DAL.Concrete.EntityFrameworkcore.Repositories;
using AKNProje.ToDo.DAL.Interface;
using AKNProje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AKNProje.ToDo.BLL.Concrete.Manager
{
    public class GorevManager : IGorevService
    {
        private readonly IGorevDAL _gorevDAL;
        public GorevManager(IGorevDAL gorevDAL)
        {
            _gorevDAL = gorevDAL;
        }

        public List<Gorev> GetGorevleriwithAllColumns()
        {
            return _gorevDAL.GetGorevleriwithAllColumns();
        }

        public Gorev GetGorevwithAciliyetandId(int id)
        {
            return _gorevDAL.GetGorevwithAciliyetandID(id);
        }

        public List<Gorev> GetGorevwithAppUserID(int appUserId)
        {
            return _gorevDAL.GetGorevwithAppUserID(appUserId);
        }

        public Gorev GetirGorevRaporlarile(int id)
        {
            return _gorevDAL.GetirGorevRaporlarile(id);
        }

        public List<Gorev> GetirHepsi()
        {
            return _gorevDAL.GetirHepsi();
        }

        public Gorev GetirIdile(int id)
        {
            return _gorevDAL.GetirIdile(id);
        }

        public void Güncelle(Gorev tablo)
        {
            _gorevDAL.Güncelle(tablo);
        }

        public void Kaydet(Gorev tablo)
        {
            _gorevDAL.Kaydet(tablo);
        }

        public void Sil(Gorev tablo)
        {
            _gorevDAL.Sil(tablo);
        }
    }
}
