using MAFBurger.WebApp.Data.Abstract;

namespace MAFBurger.WebApp.Data.Concrete
{
    public class Extra : BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderExtra> OrderExtras { get; set; } = new List<OrderExtra>();
    }
}
