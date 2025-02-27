using MAFBurger.WebApp.Data.Abstract;

namespace MAFBurger.WebApp.Data.Concrete
{
    public class OrderMenu
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int MenuId { get; set; }
        public Menu Menu { get; set; }
    }
}
