using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AKNProje.ToDo.Web.Models
{
    public class AppUserAddViewModel
    {

        [Display(Name="Kullanıcı adı")]
        [Required(ErrorMessage ="Kullanıcı adı gereklidir.")]
        public string UserName { get; set; }

        [Display(Name = " Adı :")]
        [Required(ErrorMessage = "Ad alanı gereklidir.")]
        public string Name { get; set; }

        [Display(Name = "Soyad :")]
        [Required(ErrorMessage = "Soyadı alanı gereklidir.")]
        public string Surname { get; set; }

        [Display(Name = "Şifre :")]
        [Required(ErrorMessage = "Şifre alanı gereklidir")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Tekrar şifre")]
        [Compare("Password",ErrorMessage ="Şifre ile uyuşmadı")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Email :")]
        [Required(ErrorMessage = "Email gereklidir.")]
        public string Email { get; set; }


    }
}
