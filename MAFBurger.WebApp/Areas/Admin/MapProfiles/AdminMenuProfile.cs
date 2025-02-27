using AutoMapper;
using MAFBurger.WebApp.Areas.Models;
using MAFBurger.WebApp.Data.Concrete;

namespace MAFBurger.WebApp.Areas.Admin.MapProfiles
{
    public class AdminMenuProfile : Profile
    {
        public AdminMenuProfile()
        {
            CreateMap<Menu, MenuViewModel>()
            .ForMember(dest => dest.RowNumber, opt => opt.Ignore()).ReverseMap(); // Property'yi ignore et
        }
    }
}
