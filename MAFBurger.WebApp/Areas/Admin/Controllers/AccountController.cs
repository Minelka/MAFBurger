using MAFBurger.WebApp.Areas.Models;
using MAFBurger.WebApp.Commons.Enums;
using MAFBurger.WebApp.Data.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using System.Globalization;
using System.Security.Claims;
using System.Text;

namespace MAFBurger.WebApp.Areas.Admin.Controllers
{
    //[Area("Admin")]
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<AppUser> _signInManager;
        //private readonly IMailService _mailService;
        //private readonly IFileUpload _fileUpload;

        public AccountController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<AppUser> signInManager/*, IMailService mailService, IFileUpload fileUpload*/)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            //_mailService = mailService;
            //_fileUpload = fileUpload;
        }

        public IActionResult Index()
        {
            List<AppUser> userList = _userManager.Users.ToList();
            List<IdentityRole> roleList = _roleManager.Roles.ToList();

            AccountUsersAndRolesViewModel accountUsersAndRolesViewModel = new AccountUsersAndRolesViewModel();

            //List<AccountUserViewModel> accountUserViewModelList = new List<AccountUserViewModel>();
            //List<AccountRoleViewModel> accountRoleViewModelList = new List<AccountRoleViewModel>();

            int rownumber = 1;

            foreach (AppUser user in userList)
            {
                AccountUserViewModel _auvm = new AccountUserViewModel();
                _auvm.Id = user.Id;
                _auvm.UserName = user.UserName ?? "";
                //_auvm.FirstName = user.FirstName;
                //_auvm.LastName = user.LastName;
                _auvm.Email = user.Email ?? "";
                //_auvm.BirthDate = user.BirthDate;
                //_auvm.UserTypeStr = ((UserTypes)user.UserType).ToString();
                _auvm.RowNumber = rownumber++;

                //accountUserViewModelList.Add(_auvm);
                accountUsersAndRolesViewModel.AccountUsers.Add(_auvm);
            }

            rownumber = 1;

            foreach (IdentityRole role in roleList)
            {
                AccountRoleViewModel _arvm = new AccountRoleViewModel();
                _arvm.Id = role.Id;
                _arvm.Name = role.Name ?? "";
                _arvm.RowNumber = rownumber++;

                //accountRoleViewModelList.Add(_arvm);
                accountUsersAndRolesViewModel.AccountRoles.Add(_arvm);
            }

            //ViewBag.UserList = accountUserViewModelList;
            //ViewBag.RoleList = accountRoleViewModelList;

            return View(accountUsersAndRolesViewModel);
        }

        [HttpGet]
        public IActionResult AddUser()
        {
            AccountUserAddViewModel _auvm = new AccountUserAddViewModel();

            return View(_auvm);
        }

        [HttpPost]
        public IActionResult AddUser(AccountUserAddViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            AppUser user = new AppUser();

            user.UserName = model.UserName;
            user.Email = model.Email;


            IdentityResult userResult = _userManager.CreateAsync(user, model.Password).Result;

            if (userResult.Succeeded)
            {

                Claim userType = new Claim("UserType", user.UserType.ToString());
                Claim created = new Claim("CreatedDate", user.CreatedDate.ToString());

                CultureInfo kultur = new CultureInfo("tr-TR");
                string monthName = user.CreatedDate.ToString("MMMM", kultur);
                string year = user.CreatedDate.Year.ToString();

                Claim createdInfo = new Claim("CreatedInfo", $"{monthName} {year} yılından beri üye.");


                List<Claim> userClaims = new List<Claim>();
                userClaims.Add(userType);
                userClaims.Add(created);
                userClaims.Add(createdInfo);

                IdentityResult result2 = _userManager.AddClaimsAsync(user, userClaims).Result;

                //// Email confirm maili atılacak
                //string token = _userManager.GenerateEmailConfirmationTokenAsync(user).Result;

                //// Token'ı URL dostu hale getirmek için encode et
                //var tokenEncoded = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(token));

                //string confirmationLink = Url.Action("ConfirmEmail", "Account", new { Area = "Admin", UserId = user.Id, Token = tokenEncoded }, Request.Scheme);
                //string body = $"<p>Merhaba kayıt işlemini tamamlamak için lütfen <a href={confirmationLink}>Aktivasyon Link</a>'ine tıklayınız</p>";
                //(string mailAddress, string displayName) to = (user.Email, $"{user.FirstName} {user.LastName}");

                //_mailService.SendMailAsync(to, "E-Posta Doğrulama", body, true);
            }
            else
            {
                foreach (IdentityError error in userResult.Errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);
                }

                return View(model);
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult UserRoles(string id)
        {
            AppUser? user = _userManager.FindByIdAsync(id).Result;

            if (user == null)
            {
                TempData["RecordNotFounded"] = $"{id} nolu Kullanıcı bulunamadı";
                return RedirectToAction(nameof(Index));
            }

            ViewBag.UserName = user.UserName;

            IList<string> userRoles = _userManager.GetRolesAsync(user).Result;

            List<IdentityRole> roleList = _roleManager.Roles.ToList();

            ViewBag.UserRoles = string.Join(',', userRoles);

            return View(roleList);

        }

        [HttpGet]
        public IActionResult UserRoleChange(string id, string roleId, bool status)
        {
            AppUser? user = _userManager.FindByIdAsync(id).Result;

            if (user == null)
            {
                return Json(NotFound($"{id} nolu Kullanıcı bulunamadı"));
            }

            IdentityRole? role = _roleManager.FindByIdAsync(roleId).Result;

            IdentityResult result;

            if (status)
                result = _userManager.AddToRoleAsync(user, role.Name).Result;
            else
                result = _userManager.RemoveFromRoleAsync(user, role.Name).Result;

            string durumu = status ? "eklendi." : "kaldırıldı.";

            if (result.Succeeded)
                return Json(Ok($"{user.UserName} kullanıcısı için {role.Name} rolü {durumu}"));
            else
                return Json(StatusCode(510, "Role Ekleme / Kaldırma İşlem yapılamadı"));

        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Dashboard", new { Area = "Admin" });

            LoginViewModel model = new LoginViewModel();

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            AppUser? user = await _userManager.FindByEmailAsync(model.Email);

            if (user is not null)
            {
                Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, lockoutOnFailure: true);


                if (result.Succeeded)
                    return RedirectToAction("Index", "Dashboard", new { Area = "Admin" });
                else if (result.IsLockedOut)
                {
                    ModelState.AddModelError("LockedOut", "Hesabınız kilitlenmiştir. Lütfen yetkili birim ile görüşünüz.");
                    return View(model);
                }
                else if (result.IsNotAllowed)
                {
                    ModelState.AddModelError("NotAllowed", "Hesabınız aktif değildir. Lütfen hesabınızı aktif etmek için mailinize gelen adres gidiniz.");
                    return View(model);
                }
                else if (result.RequiresTwoFactor)
                    return RedirectToAction("TwoFactor", "Account", new { Area = "Admin" });

            }

            ModelState.AddModelError("Failed", "Kullanıcı adınız veya şifreniz yanlıştır.");
            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult ConfirmEmail(ConfirmEmailViewModel model)
        {
            AppUser? user = _userManager.FindByIdAsync(model.UserId).Result;

            if (user != null)
            {
                var token = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(model.Token));

                IdentityResult result = _userManager.ConfirmEmailAsync(user, token).Result;

                if (result.Succeeded)
                    return RedirectToAction(nameof(Login));
                else
                {
                    foreach (IdentityError error in result.Errors)
                        ModelState.AddModelError(error.Code, error.Description);

                    return View(model);
                }
            }

            ModelState.AddModelError("NotFoundUser", "Bilgiler bulunamadı");

            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Logout()
        {
            _signInManager.SignOutAsync();

            return RedirectToAction(nameof(Login));
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult AccessDenied(string ReturnUrl = "")
        {

            TempData["AccessDeniedMessage"] = $"Erişmeye çalıştığınız {ReturnUrl} sayfasına yetkiniz yoktur. Sistem yöneticiniz ile görüşünüz.";
            return RedirectToAction("Index", "Dashboard", new { Area = "Admin" });
        }
    }
}
