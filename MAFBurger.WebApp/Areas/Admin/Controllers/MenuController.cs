using AutoMapper;
using MAFBurger.WebApp.Context;
using MAFBurger.WebApp.Data.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Security.Policy;
using MAFBurger.WebApp.Areas.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using MAFBurger.WebApp.Commons.Enums;

namespace MAFBurger.WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
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

            List<MenuViewModel> model = _mapper.Map<List<MenuViewModel>>(menus);


            //Burda çok tekrar eden kod var zaman olursa bunu bi çözelim.
            var beverages = Enum.GetValues(typeof(Beverage))
                   .Cast<Beverage>()
                   .Select(s => new SelectListItem
                   {
                       Text = s.GetDisplayName(),
                       Value = ((int)s).ToString()
                   }).ToList();

            ViewBag.Beverages = beverages;

            var burgerExtras = Enum.GetValues(typeof(BurgerExtras))
             .Cast<BurgerExtras>()
             .Select(s => new SelectListItem
             {
                 Text = s.GetDisplayName(),
                 Value = ((int)s).ToString()
             }).ToList();

            ViewBag.BurgerExtras = burgerExtras;

            //var sauces = Enum.GetValues(typeof(Sauce))
            // .Cast<Sauce>()
            // .Select(s => new SelectListItem
            // {
            //     Text = s.GetDisplayName(),
            //     Value = ((int)s).ToString()
            // }).ToList();

            //ViewBag.Sauces = sauces;

            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            MenuViewModel model = new MenuViewModel();

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(MenuViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            Menu menu = _mapper.Map<Menu>(model);

            _dbContext.Menus.Add(menu);
            _dbContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            Menu? menu = _dbContext.Menus.Where(m => m.Id == id && m.IsDeleted == false).FirstOrDefault();

            if (menu is null)
            {
                TempData["RecordNotFounded"] = $"Id : {id} li kayıt bulunamadığı için düzenleme yapılamıyor.";
                return RedirectToAction(nameof(Index));
            }

            MenuViewModel model = _mapper.Map<MenuViewModel>(menu);

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(MenuViewModel model)
        {
            int id = model.Id;

            if (!ModelState.IsValid)
                return View(model);

            Menu? orginalMenus = _dbContext.Menus.AsNoTracking().Where(m => m.Id == id).FirstOrDefault();

            if (orginalMenus is null)
            {
                TempData["RecordNotFounded"] = $"Id : {id} li kayıt bulunamadığı için düzenleme yapılamıyor.";
                return RedirectToAction(nameof(Index));
            }

            Menu menu = _mapper.Map<Menu>(model);

            menu.CreatedDate = orginalMenus.CreatedDate;
            menu.UpdatedDate = DateTime.Now;

            _dbContext.Menus.Update(menu);
            _dbContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Detail(int id)
        {
            Menu? menu = _dbContext.Menus.Where(m => m.Id == id && m.IsDeleted == false && m.IsActive == true).FirstOrDefault();

            if (menu is null)
            {
                TempData["RecordNotFounded"] = $"Id : {id} li kayıt bulunamadığı için düzenleme yapılamıyor.";
                return RedirectToAction(nameof(Index));
            }

            MenuViewModel model = _mapper.Map<MenuViewModel>(menu);

            return View(model);
        }


        [HttpGet]
        public IActionResult Remove(int id)
        {
            Menu? menu = _dbContext.Menus.AsNoTracking().Where(m => m.Id == id && m.IsDeleted == false).FirstOrDefault();

            if (menu is null)
            {
                TempData["RecordNotFounded"] = $"Id : {id} kayıt bulunamadığı için kayıt silinemedi.";
                return RedirectToAction(nameof(Index));
            }

            menu.IsDeleted = true;
            menu.DeletedDate = DateTime.Now;

            _dbContext.Menus.Update(menu); // Bu id başka biri tarafından gözleniyor takip
            _dbContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        //[HttpGet]
        //public IActionResult GetOutOfStockMenus(bool isJsonData = false)
        //{
        //    List<Menu> menus = _dbContext.Menus.Where(m => m.IsActive == false && m.IsDeleted == false).ToList();

        //    List<MenuViewModel> menuViewModels = _mapper.Map<List<MenuViewModel>>(menus);

        //    if (isJsonData)
        //        return Json(menuViewModels);

        //    ViewData["selectId"] = "MenuId";
        //    ViewData["selectName"] = "MenuId";

        //    return PartialView(menuViewModels);
        //}
    }
}
