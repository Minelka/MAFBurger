using MAFBurger.WebApp.Commons.Enums;
using MAFBurger.WebApp.Data.Concrete;
using MAFBurger.WebApp.Models.Abstract;
using System.ComponentModel.DataAnnotations;

namespace MAFBurger.WebApp.Areas.Models
{
    public class MenuViewModel:BaseViewModel // <string> silindi
    {
        private int _rowNumber;
        public MenuViewModel() : base(0) { }

        [Display(Name = "Menü Adı")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public string Name { get; set; }

        [Display(Name = "Menü")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public decimal Price { get; set; }

        [Display(Name = "Açıklama")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public string Description { get; set; }

        [Display(Name = "İçecek")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public Beverage Beverages { get; set; }

        [Display(Name = "Hamburger Extra")]
        public BurgerExtras BurgerExtras { get; set; }

        [Display(Name = "Soslar")]
        public Sauce Sauces { get; set; }
        public ICollection<OrderMenu> OrderMenus { get; set; } = new List<OrderMenu>();
        public override int RowNumber { get => _rowNumber; set => _rowNumber = value; }
        
    }
}
