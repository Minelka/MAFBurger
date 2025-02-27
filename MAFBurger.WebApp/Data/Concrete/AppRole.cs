using Microsoft.AspNetCore.Identity;

namespace MAFBurger.WebApp.Data.Concrete
{
    public class AppRole : IdentityRole<string>
    {
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool IsActive { get; set; } = true;
        public bool? IsDeleted { get; set; } = false;
    }


}
