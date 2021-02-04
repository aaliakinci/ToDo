using AKNProje.ToDo.DAL.Concrete.EntityFrameworkcore.Contexts;
using AKNProje.ToDo.DAL.Interface;
using AKNProje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AKNProje.ToDo.DAL.Concrete.EntityFrameworkcore.Repositories
{
    public class EfAppUserRepository : IAppUserDAL
    {
        public List<AppUser> GetAppUsersWithoutAdmin()
        {
            using (var context = new ToDoContext())
            {
               return context.Users.Join(context.UserRoles, user => user.Id, userRole => userRole.UserId, (resultUser, resultUserRole) => new
                {
                    user = resultUser,
                    userRole = resultUserRole
                }).Join(context.Roles, twoTableResult => twoTableResult.userRole.RoleId, role => role.Id, (resultTable, resultRole) => new
                {
                    user = resultTable.user,
                    userRoles = resultTable.userRole,
                    roles = resultRole

                }).Where(x => x.roles.Name == "Member").Select(x => new AppUser() {
                    Id=x.user.Id,
                    Name=x.user.Name,
                    Surname=x.user.Surname,
                    PictureUrl=x.user.PictureUrl,
                    Email=x.user.Email,
                    UserName = x.user.UserName
                
                }).ToList();
            }
        }

        public List<AppUser> GetAppUsersWithoutAdmin(out int toplamSayfa , string aranacakKelime, int sayfa=1)
        {
            using (var context = new ToDoContext())
            {
                var result = context.Users.Join(context.UserRoles, user => user.Id, userRole => userRole.UserId, (resultUser, resultUserRole) => new
                {
                    user = resultUser,
                    userRole = resultUserRole
                }).Join(context.Roles, twoTableResult => twoTableResult.userRole.RoleId, role => role.Id, (resultTable, resultRole) => new
                {
                    user = resultTable.user,
                    userRoles = resultTable.userRole,
                    roles = resultRole

                }).Where(x => x.roles.Name == "Member").Select(x => new AppUser()
                {
                    Id = x.user.Id,
                    Name = x.user.Name,
                    Surname = x.user.Surname,
                    PictureUrl = x.user.PictureUrl,
                    Email = x.user.Email,
                    UserName = x.user.UserName

                });
                toplamSayfa =(int) Math.Ceiling((double)result.Count() / 3);
                if (!string.IsNullOrEmpty(aranacakKelime))
                {
                     result = result.Where(x => x.Name.ToLower().Contains(aranacakKelime.ToLower()) || x.Surname.ToLower().Contains(aranacakKelime.ToLower()));
                    toplamSayfa = (int)Math.Ceiling((double)result.Count() / 3);
                }

                 result = result.Skip((sayfa - 1) * 3).Take(3);
                 return result.ToList();
            }
        }
    }
}
