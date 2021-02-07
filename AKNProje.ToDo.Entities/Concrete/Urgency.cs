using AKNProje.ToDo.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AKNProje.ToDo.Entities.Concrete
{
    public class Urgency : ITablo
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public List<Job> Jobs { get; set; }
    }
}
