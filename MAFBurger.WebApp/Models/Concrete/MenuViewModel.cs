using MAFBurger.WebApp.Commons.Enums;
using MAFBurger.WebApp.Data.Concrete;
using MAFBurger.WebApp.Models.Abstract;
using System.ComponentModel.DataAnnotations;

namespace MAFBurger.WebApp.Models.Concrete
{
    public class MenuViewModel : BaseViewModel
    {
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
        public Beverage Beverages { get; set; }
        public BurgerExtras BurgerExtras { get; set; }
        public Sauce Sauces { get; set; }
        public ICollection<OrderMenu> OrderMenus { get; set; } = new List<OrderMenu>();
    }
}
