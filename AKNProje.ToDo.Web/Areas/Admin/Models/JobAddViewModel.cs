using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AKNProje.ToDo.Web.Areas.Admin.Models
{
    public class JobAddViewModel
    {
        [Display(Name = "ad:")]
        [Required(ErrorMessage ="ad alanı gereklidir")]
        public string ad { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Urgency Numarası")]
        [Range(0,int.MaxValue,ErrorMessage ="Lütfen Urgency Statusu seçiniz")]
        public int UrgencyId { get; set; }

        public SelectList UrgencyListesi { get; set; }

    }
}
