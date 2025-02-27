using AutoMapper;
using MAFBurger.WebApp.Data.Concrete;
using MAFBurger.WebApp.Models.Concrete;

namespace MAFBurger.WebApp.MapProfiles
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<MenuViewModel, Menu>().ReverseMap();
        }
    }
}
