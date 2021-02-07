using AKNProje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
 

namespace AKNProje.ToDo.Web.Areas.Admin.Models
{
    public class JobWithIDViewModel
    {
        public int Id { get; set; }
        public string ad { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }

        public Urgency Urgency { get; set; }


    }
}
