using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AKNProje.ToDo.Web.Models
{
    public class AppUserLoginViewModel
    {
        [Display(Name = "Kullanıcı adı")]
        [Required(ErrorMessage = "Kullanıcı adı gereklidir.")]
        public string UserName { get; set; }

        [Display(Name = "Şifre :")]
        [Required(ErrorMessage = "Şifre alanı gereklidir")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name ="Beni Hatırla :")]

        public bool IsPresistent { get; set; }


    }
}
