using AKNProje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AKNProje.ToDo.Web.Areas.Member.Models
{
    public class ReportAddViewModel
    {
        [Display(Name = "Tanım")]
        [Required(ErrorMessage ="Tanım alanı boş geçilemez")]
        public string Description { get; set; }


        [Display(Name = "Detail")]
        [Required(ErrorMessage = "Detail alanı boş geçilemez")]
        public string Detail { get; set; }

        public Job Job { get; set; }
        public int JobId { get; set; }
    }
}
