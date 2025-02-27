using System.ComponentModel.DataAnnotations;
using static MAFBurger.WebApp.Models.Abstract.BaseViewModel;
using System.Collections.Generic;

namespace MAFBurger.WebApp.Models.Abstract
{
    public class BaseViewModel
    {
        private static int _rowNumber;

        protected BaseViewModel(int rowNumber)
        {
            _rowNumber = rowNumber;
        }

        public virtual int RowNumber
        {
            get
            {
                _rowNumber = _rowNumber + 1;
                return _rowNumber;
            }
            set
            {
                _rowNumber = value;
            }
        }
        [Display(Name = "ID")]
        public int Id { get; set; }
        [Display(Name = "Durumu")]
        public bool IsActive { get; set; }

        [Display(Name = "Oluşturma Tarihi")]
        public DateTime Created { get; set; } = DateTime.Now;

        [Display(Name = "Güncelleme Tarihi")]
        public DateTime? Updated { get; set; }

        [Display(Name = "Silinme Tarihi")]
        public DateTime? Deleted { get; set; }

    }
}
