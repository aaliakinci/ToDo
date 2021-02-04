using AKNProje.ToDo.Entities.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AKNProje.ToDo.Web.Areas.Admin.Models
{
    public class GorevUpdateViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Ad:")]
        [Required(ErrorMessage = "Ad alanı gereklidir")]
        public string Ad { get; set; }
        [Display(Name = "Aciklama")]
        public string Aciklama { get; set; }


        [Display(Name = "Aciliyet Numarası")]
        [Range(0, int.MaxValue, ErrorMessage = "Lütfen aciliyet durumu seçiniz")]
        public int AciliyetId { get; set; }


        public SelectList AciliyetListesi { get; set; }
    }
}
