using AutoMapper;
using MAFBurger.WebApp.Data.Concrete;
using MAFBurger.WebApp.Models.Concrete;

namespace MAFBurger.WebApp.MapProfiles
{
    public class MenuProfile : Profile
    {
     public MenuProfile() 
        {
            CreateMap<MenuViewModel, Menu>().ReverseMap(); 
        }
    }
}
