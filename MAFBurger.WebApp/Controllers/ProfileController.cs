using AutoMapper;
using MAFBurger.WebApp.Context;
using MAFBurger.WebApp.Data.Concrete;
using MAFBurger.WebApp.Models.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MAFBurger.WebApp.Controllers
{
    //[Authorize(Policy = "PublicPolicy")]
    public class ProfileController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
