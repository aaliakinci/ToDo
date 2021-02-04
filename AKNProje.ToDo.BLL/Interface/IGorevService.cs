using AKNProje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AKNProje.ToDo.BLL.Interface
{
    public interface IGorevService : IGenericService<Gorev>
    {
        List<Gorev> GetGorevleriwithAllColumns();
        Gorev GetGorevwithAciliyetandId(int id);
        List<Gorev> GetGorevwithAppUserID(int appUserId);
        Gorev GetirGorevRaporlarile(int id);
    }
}
