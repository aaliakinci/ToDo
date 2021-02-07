using AKNProje.ToDo.DAL.Interface;
using AKNProje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AKNProje.ToDo.BLL.Interface
{
    public interface IAppUserService 
    {
        List<AppUser> GetAppUsersWithoutAdmin();
        List<AppUser> GetAppUsersWithoutAdmin(out int totalPage, string searchWord, int page);
    }
}
