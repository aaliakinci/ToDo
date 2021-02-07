using AKNProje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AKNProje.ToDo.Web.Areas.Admin.Models
{
    public class JobListViewModel
    {
        public int ID { get; set; }
        public string ad { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedAt { get; set; }

        public int UrgencyId { get; set; }
        public Urgency Urgency { get; set; }
    }
}
