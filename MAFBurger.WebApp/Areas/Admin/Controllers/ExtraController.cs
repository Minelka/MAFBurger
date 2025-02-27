using AutoMapper;
using MAFBurger.WebApp.Context;
using MAFBurger.WebApp.Data.Concrete;
using MAFBurger.WebApp.Models.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MAFBurger.WebApp.Areas.Admin.Controllers
{
    //[Area("Admin")]
    public class ExtraController : Controller
    {
        private readonly MAFBurgerDbContext _dbContext;
        private IMapper _mapper;

        public ExtraController(MAFBurgerDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public IActionResult Index()
        {

            List<Extra> extras = _dbContext.Extras.Where(e => e.IsDeleted == false && e.IsActive == true).ToList();
            List<ExtraViewModel> model = _mapper.Map<List<ExtraViewModel>>(extras);

            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ExtraViewModel model = new ExtraViewModel();

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(ExtraViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            Extra extra = _mapper.Map<Extra>(model);

            _dbContext.Extras.Add(extra);
            _dbContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            Extra? extra = _dbContext.Extras.Where(e => e.Id == id && e.IsDeleted == false).FirstOrDefault();

            if (extra is null)
            {
                TempData["RecordNotFounded"] = $"Id : {id} li kayıt bulunamadığı için düzenleme yapılamıyor.";
                return RedirectToAction(nameof(Index));
            }

            ExtraViewModel model = _mapper.Map<ExtraViewModel>(extra);

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ExtraViewModel model)
        {
            int id = model.Id;

            if (!ModelState.IsValid)
                return View(model);

            Extra? orginalExtras = _dbContext.Extras.AsNoTracking().Where(e => e.Id == id).FirstOrDefault();

            if (orginalExtras is null)
            {
                TempData["RecordNotFounded"] = $"Id : {id} li kayıt bulunamadığı için düzenleme yapılamıyor.";
                return RedirectToAction(nameof(Index));
            }

            Extra extra = _mapper.Map<Extra>(model);

            extra.CreatedDate = orginalExtras.CreatedDate;
            extra.UpdatedDate = DateTime.Now;

            _dbContext.Extras.Update(extra);
            _dbContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Detail(int id)
        {
            Extra? extra = _dbContext.Extras.Where(e => e.Id == id && e.IsDeleted == false && e.IsActive == true).FirstOrDefault();

            if (extra is null)
            {
                TempData["RecordNotFounded"] = $"Id : {id} li kayıt bulunamadığı için düzenleme yapılamıyor.";
                return RedirectToAction(nameof(Index));
            }

            ExtraViewModel model = _mapper.Map<ExtraViewModel>(extra);

            return View(model);
        }


        [HttpGet]
        public IActionResult Remove(int id)
        {
            Extra? extra = _dbContext.Extras.AsNoTracking().Where(e => e.Id == id && e.IsDeleted == false).FirstOrDefault();

            if (extra is null)
            {
                TempData["RecordNotFounded"] = $"Id : {id} kayıt bulunamadığı için kayıt silinemedi.";
                return RedirectToAction(nameof(Index));
            }

            extra.IsDeleted = true;
            extra.DeletedDate = DateTime.Now;

            _dbContext.Extras.Update(extra); // Bu id başka biri tarafından gözleniyor takip
            _dbContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        //[HttpGet]
        //public IActionResult GetOutOfStockExtras(bool isJsonData = false)
        //{
        //    List<Extra> extras = _dbContext.Extras.Where(e => e.IsActive == false && e.IsDeleted == false).ToList();

        //    List<ExtraViewModel> extraViewModels = _mapper.Map<List<ExtraViewModel>>(extras);

        //    if (isJsonData)
        //        return Json(extraViewModels);

        //    ViewData["selectId"] = "ExtraId";
        //    ViewData["selectName"] = "ExtraId";

        //    return PartialView(extraViewModels);
        //}
    }
}
