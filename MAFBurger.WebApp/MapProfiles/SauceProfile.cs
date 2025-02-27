using AutoMapper;
using MAFBurger.WebApp.Data.Concrete;
using MAFBurger.WebApp.Models.Concrete;

namespace MAFBurger.WebApp.MapProfiles
{
    public class SauceProfile:Profile
    {
        public SauceProfile()
        {
            CreateMap<SauceViewModel, Sauce>().ReverseMap();
        }
    }
}
