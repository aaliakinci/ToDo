using AKNProje.ToDo.BLL.Interface;
using AKNProje.ToDo.DAL.Interface;
using AKNProje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AKNProje.ToDo.BLL.Concrete.Manager
{
    public class AppUserManager : IAppUserService
    {
        private readonly IAppUserDAL _appUserDAL;
        public AppUserManager(IAppUserDAL appUserDAL)
        {
            _appUserDAL = appUserDAL;
        }
        public List<AppUser> GetAppUsersWithoutAdmin()
        {
            return _appUserDAL.GetAppUsersWithoutAdmin();
        }

        public List<AppUser> GetAppUsersWithoutAdmin(out int totalPage , string searchWord, int page)
        {
            return _appUserDAL.GetAppUsersWithoutAdmin(out totalPage,searchWord, page);
        }
    }
}
