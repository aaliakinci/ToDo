using AKNProje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AKNProje.ToDo.Web.Areas.Admin.Models
{
    public class GorevWithIDViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Aciklama { get; set; }
        public DateTime OlusturulmaTarihi { get; set; }

        public Aciliyet Aciliyet { get; set; }


    }
}
