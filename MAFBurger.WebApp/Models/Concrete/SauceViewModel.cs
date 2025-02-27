using MAFBurger.WebApp.Data.Concrete;
using MAFBurger.WebApp.Models.Abstract;
using System.ComponentModel.DataAnnotations;

namespace MAFBurger.WebApp.Models.Concrete
{
    public class SauceViewModel : BaseViewModel
    {
        public SauceViewModel() : base(0) { }

        [Display(Name = "Ekstra Sos Adı")]
        public string Name { get; set; }

        [Display(Name = "Ekstra Sos Adı")]
        public decimal Price { get; set; }
        public ICollection<OrderExtra> OrderExtras { get; set; } = new List<OrderExtra>();
    }
}
