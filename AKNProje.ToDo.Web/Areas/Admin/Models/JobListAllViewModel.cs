using AKNProje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AKNProje.ToDo.Web.Areas.Admin.Models

{
    public class JobListAllViewModel
    {
        public int ID { get; set; }
        public string ad { get; set; }
        public string Description { get; set; }
       
        public DateTime CreatedAt { get; set; } = DateTime.Now;


        public Urgency Urgency { get; set; }

        public List<Report> Report { get; set; }
     
        public AppUser AppUser { get; set; }


    }
}
