using AKNProje.ToDo.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AKNProje.ToDo.DAL.Interface
{
    public interface IGenericDAL<Tablo> where Tablo:class,ITablo,new()
    {
        void Save(Tablo tablo);
        void Delete(Tablo tablo);
        void Update(Tablo tablo);
        Tablo GetById(int id);
        List<Tablo> GetAll();
    }
}
