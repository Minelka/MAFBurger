using MAFBurger.WebApp.Commons.Enums;
using MAFBurger.WebApp.Data.Abstract;
using MAFBurger.WebApp.Models;


namespace MAFBurger.WebApp.Data.Concrete
{
    public class Order : BaseEntity
    {
        public virtual ICollection<OrderMenu> OrderMenus { get; set; } = new List<OrderMenu>();
        public Size Size { get; set; }
        public virtual ICollection<OrderExtra> OrderExtras { get; set; } = new List<OrderExtra>();
        public int Quantity { get; set; }

        //public int Price { get; set; }
        public string? AppUserId { get; set; }
        public AppUser? AppUser { get; set; }
    }
}
