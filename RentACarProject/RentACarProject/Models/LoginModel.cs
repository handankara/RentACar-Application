using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RentACarProject.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Lütfen mail adresinizi giriniz.")] //gerekli kısım
        [Display(Name = "Email")]//Bu ekranda görünen isim
        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi giriniz.")]//gerekli kısım
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        [Display(Name = "Şifre")]//Bu ekranda görünen isim
        public string Sifre { get; set; }
    }
}