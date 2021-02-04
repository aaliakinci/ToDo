using AKNProje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AKNProje.ToDo.Web.Areas.Admin.Models
{
    public class PersonelGorevViewModel
    {
        public GorevListAllViewModel Gorev { get; set; }
        public AppUserListViewModel AppUser { get; set; }
    }
}
