using MAFBurger.WebApp.Data.Concrete;
using MAFBurger.WebApp.Models.Abstract;
using System.ComponentModel.DataAnnotations;

namespace MAFBurger.WebApp.Models.Concrete
{
    public class ExtraViewModel : BaseViewModel
    {
        public ExtraViewModel() : base(0) { }

        [Display(Name = "Ekstra Malzeme Adı")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public string Name { get; set; }

        [Display(Name = "Ekstra Malzeme Adı")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public decimal Price { get; set; }
        public ICollection<OrderExtra> OrderExtras { get; set; } = new List<OrderExtra>();
    }
}
