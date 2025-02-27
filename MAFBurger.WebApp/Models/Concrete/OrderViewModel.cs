using MAFBurger.WebApp.Models.Abstract;
using MAFBurger.WebApp.Commons.Enums;
using System.ComponentModel.DataAnnotations;
using MAFBurger.WebApp.Data.Concrete;

namespace MAFBurger.WebApp.Models.Concrete
{
    public class OrderViewModel : BaseViewModel
    {
        public OrderViewModel() : base(0) { }
        [Display(Name = "Sipariş Boyutu")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public Size Size { get; set; }

        [Display(Name = "Sipariş Miktarı")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public int Quantity { get; set; }

        //public int Price { get; set; }
        public string? AppUserId { get; set; }

        public AppUser AppUser { get; set; }
        public ICollection<OrderMenu> OrderMenus { get; set; } = new List<OrderMenu>();
        public ICollection<OrderExtra> OrderExtras { get; set; } = new List<OrderExtra>();
    }
}

