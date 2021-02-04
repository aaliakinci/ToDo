using AKNProje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AKNProje.ToDo.Web.Areas.Admin.Models
{
    public class GorevListAllViewModel
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
       
        public DateTime OlusturulmaTarihi { get; set; } = DateTime.Now;


        public Aciliyet Aciliyet { get; set; }

        public List<Rapor> Rapor { get; set; }
     
        public AppUser AppUser { get; set; }


    }
}
