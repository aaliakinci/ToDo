using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AKNProje.ToDo.Web.Areas.Admin.Models
{
    public class AppUserListViewModel
    {
        public int Id { get; set; }
        [Display(Name="Ad")]
        [Required(ErrorMessage ="Ad Alanı boş geçilemez")]
        public string Name { get; set; }
        [Display(Name = "Soyad")]

        [Required(ErrorMessage = "SoyAd Alanı boş geçilemez")]

        public string Surname { get; set; }
        

        public string Picture { get; set; }
        [Display(Name = "Email")]

        [Required(ErrorMessage = "Email Alanı boş geçilemez")]

        public string Email { get; set; }

    }
}
