using MAFBurger.WebApp.Commons.Enums;
using MAFBurger.WebApp.Data.Concrete;
using Microsoft.AspNetCore.Identity;


namespace MAFBurger.WebApp.Data.Concrete
{
    public class AppUser : IdentityUser
    {
        
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool IsActive { get; set; } = true;
        public bool? IsDeleted { get; set; } = false;
        public UserType UserType { get; set; }
        public virtual ICollection<Order> Orders {  get; set; } = new List<Order>();
    }
}
