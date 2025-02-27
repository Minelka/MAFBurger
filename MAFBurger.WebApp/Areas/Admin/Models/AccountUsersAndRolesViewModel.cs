namespace MAFBurger.WebApp.Areas.Models
{
    public class AccountUsersAndRolesViewModel
    {
        public List<AccountUserViewModel> AccountUsers { get; set; } = new List<AccountUserViewModel>();
        public List<AccountRoleViewModel> AccountRoles { get; set; } = new List<AccountRoleViewModel>();
    }
}
