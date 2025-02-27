using System.ComponentModel.DataAnnotations;

namespace MAFBurger.WebApp.Areas.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Bu alan zorunludur")]
        [Display(Name = "E-Posta Adresi")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "E-Posta adresiniz doğru değil")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Bu alan zorunludur")]
        [DataType(DataType.Password)]
        [Display(Name = "Şifre")]
        public string Password { get; set; } = null!;

        [Display(Name = "Hatırla Beni")]
        public bool RememberMe { get; set; }
    }
}
