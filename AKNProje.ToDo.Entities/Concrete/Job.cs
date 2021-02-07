using AKNProje.ToDo.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AKNProje.ToDo.Entities.Concrete
{
   public  class Job : ITablo
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.Now;


        public int UrgencyId{ get; set; }
        public Urgency Urgency { get; set; }



        public  List<Report> Report { get; set; }


        public int? AppUserId { get; set; }
        public AppUser AppUser { get; set; }

    } 
}
