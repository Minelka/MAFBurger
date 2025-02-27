using MAFBurger.WebApp.Commons.Enums;
using MAFBurger.WebApp.Models.Abstract;
using System.ComponentModel.DataAnnotations;

namespace MAFBurger.WebApp.Areas.Models
{
    public class AccountUserViewModel : BaseViewModel
    {
        private int _rowNumber;

        public AccountUserViewModel() : base(0){}

        public string? Id { get; set; }

        [Display(Name = "E-Posta Adresi")]
        [Required(ErrorMessage = "Bu alan zorunludur")]
        public string Email { get; set; } = string.Empty;

        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Bu alan zorunludur")]
        public string UserName { get; set; } = string.Empty;

        public string? UserTypeStr { get; set; }

        [Display(Name = "Kullanıcı Tipi")]
        [Required(ErrorMessage = "Bu alan zorunludur")]
        public UserType UserType { get; set; }


        public override int RowNumber { get => _rowNumber; set => _rowNumber = value; }
    }
}
