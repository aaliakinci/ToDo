using AKNProje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AKNProje.ToDo.DAL.Interface
{
    public interface IAppUserDAL 
    {
        public List<AppUser> GetAppUsersWithoutAdmin();
        public List<AppUser> GetAppUsersWithoutAdmin(out int toplamSayfa ,string aranacakKelime, int sayfa);
    }
}
