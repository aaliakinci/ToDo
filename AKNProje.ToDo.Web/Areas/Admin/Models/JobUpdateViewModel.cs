using AKNProje.ToDo.Entities.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AKNProje.ToDo.Web.Areas.Admin.Models
{
    public class JobUpdateViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Görev Adı:")]
        [Required(ErrorMessage = "Görev adı gereklidir")]
        public string ad { get; set; }
        [Display(Name = "Açıklama")]
        public string Description { get; set; }


        [Display(Name = "Aciliyet Durumu")]
        [Range(0, int.MaxValue, ErrorMessage = "Lütfen Aciliyet durumu seçiniz")]
        public int UrgencyId { get; set; }


        public SelectList UrgencyListesi { get; set; }
    }
}
