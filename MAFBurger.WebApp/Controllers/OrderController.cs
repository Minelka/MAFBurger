using AutoMapper;
using MAFBurger.WebApp.Commons.Enums;
using MAFBurger.WebApp.Context;
using MAFBurger.WebApp.Data.Concrete;
using MAFBurger.WebApp.Models.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MAFBurger.WebApp.Controllers
{
	//[Area("Admin")]
	public class OrderController : Controller
	{
		private readonly MAFBurgerDbContext _dbContext;
		private IMapper _mapper;

		public OrderController(MAFBurgerDbContext dbContext)
		{
			_dbContext = dbContext;

		}

		public IActionResult Index()	
		{

			List<Order> orders = _dbContext.Orders.Include(o => o.OrderMenus).ThenInclude(m => m.Menu).Include(o => o.OrderExtras).ThenInclude(e => e.Extra).Include(o => o.AppUser).Where(o => o.IsDeleted == false && o.IsActive == true).ToList();

			List<OrderViewModel> model = _mapper.Map<List<OrderViewModel>>(orders);

			return View(model);

		}

		[HttpGet]
		public IActionResult Add()
		{
			OrderViewModel model = new OrderViewModel();

			return View(model);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Add(OrderViewModel model)
		{


			List<Menu> menus = _dbContext.Menus.Where(m => m.IsDeleted == false && m.IsActive == true).ToList();
			List<MenuViewModel> menuModel = _mapper.Map<List<MenuViewModel>>(menus);

			ViewBag.Menu = menuModel;

			if (!ModelState.IsValid)
				return View(model);

			Order order = _mapper.Map<Order>(model);

			_dbContext.Orders.Add(order);
			_dbContext.SaveChanges();

			return RedirectToAction(nameof(Index));
		}

		public IActionResult Edit(int id)
		{
			Order? order = _dbContext.Orders.Where(o => o.Id == id && o.IsDeleted == false).FirstOrDefault();

			if (order is null)
			{
				TempData["RecordNotFounded"] = $"Id : {id} li kayıt bulunamadığı için düzenleme yapılamıyor.";
				return RedirectToAction(nameof(Index));
			}

			OrderViewModel model = _mapper.Map<OrderViewModel>(order);

			return View(model);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Edit(OrderViewModel model)
		{
			int id = model.Id;

			if (!ModelState.IsValid)
				return View(model);

			Menu? orginalOrders = _dbContext.Menus.AsNoTracking().Where(o => o.Id == id).FirstOrDefault();

			if (orginalOrders is null)
			{
				TempData["RecordNotFounded"] = $"Id : {id} li kayıt bulunamadığı için düzenleme yapılamıyor.";
				return RedirectToAction(nameof(Index));
			}

			Order order = _mapper.Map<Order>(model);

			order.CreatedDate = orginalOrders.CreatedDate;
			order.UpdatedDate = DateTime.Now;

			_dbContext.Orders.Update(order);
			_dbContext.SaveChanges();

			return RedirectToAction(nameof(Index));
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


		[HttpGet]
		public IActionResult Remove(int id)
		{
			Order? order = _dbContext.Orders.AsNoTracking().Where(o => o.Id == id && o.IsDeleted == false).FirstOrDefault();

			if (order is null)
			{
				TempData["RecordNotFounded"] = $"Id : {id} kayıt bulunamadığı için kayıt silinemedi.";
				return RedirectToAction(nameof(Index));
			}

			order.IsDeleted = true;
			order.DeletedDate = DateTime.Now;

			_dbContext.Orders.Update(order); // Bu id başka biri tarafından gözleniyor takip
			_dbContext.SaveChanges();

			return RedirectToAction(nameof(Index));
		}

		[HttpGet]
		public IActionResult GetHistoryOrders(bool isJsonData = false)
		{
			List<Order> orders = _dbContext.Orders.Where(o => o.IsActive == false && o.IsDeleted == false).ToList();

			List<OrderViewModel> orderViewModels = _mapper.Map<List<OrderViewModel>>(orders);

			if (isJsonData)
				return Json(orderViewModels);

			ViewData["selectId"] = "OrderId";
			ViewData["selectName"] = "OrderId";

			return PartialView(orderViewModels);
		}
	}
}
