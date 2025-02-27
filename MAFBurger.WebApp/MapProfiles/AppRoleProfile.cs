using AutoMapper;
using MAFBurger.WebApp.Data.Concrete;
using MAFBurger.WebApp.Models.Concrete;

namespace MAFBurger.WebApp.MapProfiles
{
    public class AppRoleProfile: Profile
    {
        public AppRoleProfile()
        {
            CreateMap<MenuViewModel, Menu>().ReverseMap();
        }
    }
}
