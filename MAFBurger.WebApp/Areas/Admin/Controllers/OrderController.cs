using AutoMapper;
using MAFBurger.WebApp.Context;
using MAFBurger.WebApp.Data.Concrete;
using MAFBurger.WebApp.Models.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MAFBurger.WebApp.Controllers
{
    [Area("Admin")]
    public class OrderController : Controller
    {
        private readonly MAFBurgerDbContext _dbContext;
        private IMapper _mapper;

        public OrderController(MAFBurgerDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public IActionResult Index()
        {

            List<Order> orders = _dbContext.Orders.Include(o => o.OrderMenus).ThenInclude(m => m.Menu).Include(o => o.OrderExtras).ThenInclude(e => e.Extra).Include(o => o.AppUser).Where(o => o.IsDeleted == false && o.IsActive == true).ToList();

            List<OrderViewModel> model = _mapper.Map<List<OrderViewModel>>(orders);

            return View(model);
        }

        [HttpGet]
        public IActionResult Detail(int id)
        {
            Order? order = _dbContext.Orders.Where(o => o.Id == id && o.IsDeleted == false && o.IsActive == true).FirstOrDefault();

            if (order is null)
            {
                TempData["RecordNotFounded"] = $"Id : {id} li kayıt bulunamadığı için düzenleme yapılamıyor.";
                return RedirectToAction(nameof(Index));
            }

            OrderViewModel model = _mapper.Map<OrderViewModel>(order);

            return View(model);
        }

        //ekstra sorgu yazılacak
       
    }
}
