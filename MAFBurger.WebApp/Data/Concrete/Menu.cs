using MAFBurger.WebApp.Commons.Enums;
using MAFBurger.WebApp.Data.Abstract;
using System.ComponentModel.DataAnnotations;

namespace MAFBurger.WebApp.Data.Concrete
{
    public class Menu : BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public Beverage? Beverages { get; set; }
        public BurgerExtras? BurgerExtras { get; set; }
        public Sauce? Sauces { get; set; }
        public virtual ICollection<OrderMenu> OrderMenus { get; set; } = new List<OrderMenu>();
    }
}
