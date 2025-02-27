using MAFBurger.WebApp.Data.Abstract;

namespace MAFBurger.WebApp.Data.Concrete
{
    public class OrderExtra 
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int ExtraId { get; set; }
        public Extra Extra { get; set; }
    }
}
