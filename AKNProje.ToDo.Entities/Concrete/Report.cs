using AKNProje.ToDo.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AKNProje.ToDo.Entities.Concrete
{
    public class Report : ITablo
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Detail { get; set; }


        public int JobId { get; set; }
        public Job Job { get; set; }

    }
}
