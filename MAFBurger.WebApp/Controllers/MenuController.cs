using AutoMapper;
using MAFBurger.WebApp.Commons.Enums;
using MAFBurger.WebApp.Context;
using MAFBurger.WebApp.Data.Concrete;
using MAFBurger.WebApp.Models.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MAFBurger.WebApp.Controllers
{
    public class MenuController : Controller
    {
        private readonly MAFBurgerDbContext _dbContext;
        private IMapper _mapper;

        public MenuController(MAFBurgerDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public IActionResult Index()
        {

            List<Menu> menus = _dbContext.Menus.Where(m => m.IsDeleted == false && m.IsActive == true).ToList();
            List<MenuViewModel> menuModel = _mapper.Map<List<MenuViewModel>>(menus);

            List<Sauce> sauces = _dbContext.Sauces.Where(m => m.IsDeleted == false && m.IsActive == true).ToList();
            List<SauceViewModel> sauceModel = _mapper.Map<List<SauceViewModel>>(sauces);

            ViewBag.sauce = sauceModel;

            return View(menuModel);
        }

        [HttpGet]
        public IActionResult Add()
        {
            MenuViewModel model = new MenuViewModel();

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(int menuId, int size, int quantity, string? userId, List<int> selectedExtras)
        {
            // Menü kontrolü
            var menu = _dbContext.Menus.FirstOrDefault(m => m.Id == menuId);
            if (menu == null)
            {
                return NotFound("Seçtiğiniz menü bulunamadı.");
            }

            // Sipariş oluştur
            var order = new Order
            {
                Size = (Size)size, // Enum türü (Small, Medium, Large gibi)
                Quantity = quantity,
                AppUserId = userId,
                OrderMenus = new List<OrderMenu>
                {
                    new OrderMenu { MenuId = menuId }
                },
                OrderExtras = selectedExtras.Select(extraId => new OrderExtra { ExtraId = extraId }).ToList(),
                // OrderExtra: seçilen ekstraları ilişkilendirir.
            };

            // Siparişi veritabanına kaydet
            _dbContext.Orders.Add(order);
            _dbContext.SaveChanges();

            TempData["SuccessMessage"] = "Siparişiniz başarıyla oluşturuldu!";
            return RedirectToAction("Index");
        }
    }
}
