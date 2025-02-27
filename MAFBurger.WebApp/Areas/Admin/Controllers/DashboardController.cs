using AutoMapper;
using MAFBurger.WebApp.Context;
using MAFBurger.WebApp.Controllers;
using MAFBurger.WebApp.Data.Concrete;
using MAFBurger.WebApp.Models;
using MAFBurger.WebApp.Models.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace MAFBurger.WebApp.Areas.Admin.Controllers
{
    //[Area("Admin")]
    //[Authorize(Policy = "AdminPolicy")]
    public class DashboardController : Controller
    {
        //ILogger kısmını kaldırdım gerekirse tekrardan ekleriz.
        
        private readonly MAFBurgerDbContext _dbContext;
        private IMapper _mapper;


        public DashboardController(MAFBurgerDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            List<Order> orders = _dbContext.Orders.Include(o => o.OrderMenus).ThenInclude(m => m.Menu).Include(o => o.OrderExtras).ThenInclude(o => o.Extra).Where(o => o.IsDeleted == false && o.IsActive == true).ToList();

            
            var mostOrderedMenu = _dbContext.Orders
                .Where(o => o.IsDeleted == false && o.IsActive == true)
                .Include(o => o.OrderMenus)             
                .ThenInclude(o => o.Menu)             
                .SelectMany(o => o.OrderMenus)          
                .GroupBy(o => o.MenuId)                 
                .OrderByDescending(o => o.Count())      
                .FirstOrDefault();                      

            var mostOrderedMenuName = mostOrderedMenu != null
            ? _dbContext.Menus.Where(o => o.Id == mostOrderedMenu.Key).Select(o => o.Name).FirstOrDefault()
            : "böyle bir ad bulunamadı";

            var mostOrderedExtra = _dbContext.Orders
            .Where(o => o.IsDeleted == false && o.IsActive == true)
            .Include(o => o.OrderExtras)                
            .ThenInclude(o => o.Extra)                
            .SelectMany(o => o.OrderExtras)             
            .GroupBy(o => o.ExtraId)                    
            .OrderByDescending(o => o.Count())          
            .FirstOrDefault();                          

            var mostOrderedExtraName = mostOrderedExtra != null
           ? _dbContext.Extras.Where(o => o.Id == mostOrderedExtra.Key).Select(o => o.Name).FirstOrDefault()
           : "Bilinmiyor";

            ViewData["MostOrderedMenu"] = mostOrderedMenuName;
            ViewData["MostOrderedExtra"] = mostOrderedExtraName;

            List<OrderViewModel> model = _mapper.Map<List<OrderViewModel>>(orders);

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
