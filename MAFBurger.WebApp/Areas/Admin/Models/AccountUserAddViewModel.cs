using System.ComponentModel.DataAnnotations;

namespace MAFBurger.WebApp.Areas.Models
{
    public class AccountUserAddViewModel : AccountUserViewModel
    {
        [Required(ErrorMessage = "Bu alan zorunludur")]
        [RegularExpression("^(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{10,}$", ErrorMessage = "Şifrenizde En az 10 karakterden ve içerisinde 1 Büyük, 1 Küçük, 1 özel karakter ve 1 sayısal değer olmalıdır.")]
        [DataType(DataType.Password)]
        [Display(Name = "Şifre")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur")]
        [Compare("Password", ErrorMessage = "Şifreler aynı değil")]
        [DataType(DataType.Password)]
        [Display(Name = "Şifre Tekrarı")]
        public string PasswordAgain { get; set; }
    }
}
