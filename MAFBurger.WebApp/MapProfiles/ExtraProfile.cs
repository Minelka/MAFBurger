using AutoMapper;
using MAFBurger.WebApp.Data.Concrete;
using MAFBurger.WebApp.Models.Concrete;

namespace MAFBurger.WebApp.MapProfiles
{
    public class ExtraProfile : Profile
    {
        public ExtraProfile()
        {
            CreateMap<MenuViewModel, Menu>().ReverseMap();
        }
    }
}
