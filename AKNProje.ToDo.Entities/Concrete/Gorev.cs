using AKNProje.ToDo.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AKNProje.ToDo.Entities.Concrete
{
   public  class Gorev : ITablo
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public bool Durum { get; set; }
        public DateTime OlusturulmaTarihi { get; set; } = DateTime.Now;


        public int AciliyetId{ get; set; }
        public Aciliyet Aciliyet { get; set; }



        public  List<Rapor> Rapor { get; set; }


        public int? AppUserId { get; set; }
        public AppUser AppUser { get; set; }

    } 
}
