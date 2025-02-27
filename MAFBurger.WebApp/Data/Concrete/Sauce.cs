using MAFBurger.WebApp.Data.Abstract;

namespace MAFBurger.WebApp.Data.Concrete
{
    public class Sauce : BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
