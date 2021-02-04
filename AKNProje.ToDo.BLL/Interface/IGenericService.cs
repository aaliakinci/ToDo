using AKNProje.ToDo.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AKNProje.ToDo.BLL.Interface
{
    public interface IGenericService<Tablo> where Tablo : class,ITablo,new()
    {
        void Kaydet(Tablo tablo);
        void Sil(Tablo tablo);
        void Güncelle(Tablo tablo);
        Tablo GetirIdile(int id);
        List<Tablo> GetirHepsi();
    }
}
