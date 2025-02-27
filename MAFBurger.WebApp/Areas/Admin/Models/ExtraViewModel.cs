using MAFBurger.WebApp.Commons.Enums;
using MAFBurger.WebApp.Data.Concrete;
using MAFBurger.WebApp.Models.Abstract;
using System.ComponentModel.DataAnnotations;

namespace MAFBurger.WebApp.Areas.Models
{
    public class ExtraViewModel : BaseViewModel
    {
        
        private int _rowNumber;
        public ExtraViewModel() : base(0) { }

        [Display(Name = "Extra Malzeme Adı")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public string Name { get; set; }

        [Display(Name = "Extra Malzeme Fiyatı")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public decimal Price { get; set; }

        public ICollection<OrderExtra> OrderExtras { get; set; } = new List<OrderExtra>();

        //public override int RowNumber { get => this._rowNumber; set => _rowNumber = value; }
    }
}
