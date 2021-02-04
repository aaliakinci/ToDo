using AKNProje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AKNProje.ToDo.DAL.Interface
{
    public interface IGorevDAL :IGenericDAL<Gorev>
    {
        List<Gorev> GetGorevleriwithAllColumns();
        Gorev GetGorevwithAciliyetandID(int id);
        List<Gorev> GetGorevwithAppUserID(int appUserId);
        Gorev GetirGorevRaporlarile(int id);
    }
}
