using MAFBurger.WebApp.Data.Concrete;
using MAFBurger.WebApp.Models.Abstract;

namespace MAFBurger.WebApp.Models.Concrete
{
    public class AppUserViewModel : BaseViewModel
    {
        public AppUserViewModel() : base(0) { }
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
