using MAFBurger.WebApp.Models.Abstract;

namespace MAFBurger.WebApp.Areas.Models
{
    public class AccountRoleViewModel : BaseViewModel
    {
        private int _rowNumber;

        public AccountRoleViewModel() : base(0)
        {}
        
        public string Id { get; set; }
        public string Name { get; set; }

        public override int RowNumber { get => _rowNumber; set => _rowNumber = value; }
    }
}
