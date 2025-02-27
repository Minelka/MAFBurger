using MAFBurger.WebApp.Data.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MAFBurger.WebApp.Context;
using System.Security.Principal;
using MAFBurger.WebApp.Models;
using System.Reflection.Emit;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("MAFBurgerWebAppContextConnection") ?? throw new InvalidOperationException("Connection string 'MAFBurgerWebAppContextConnection' not found.");

builder.Services.AddDbContext<MAFBurgerDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<AppUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = true;
}).AddEntityFrameworkStores<MAFBurgerDbContext>();

// Add services to the container.
//builder.Services.AddDbContext<MAFBurgerDbContext>(opt=> 
//{
//    opt.UseSqlServer(builder.Configuration.GetConnectionString("conn"));
//});


builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddAuthentication()
                .AddCookie("AdminScheme", opt =>
                {
                    opt.Cookie.Name = ".AspNetCore.Identity.Application";
                    opt.LoginPath = "/Identity/Account/Login";
                    opt.LogoutPath = "/Identity/Account/Logout";
                    opt.AccessDeniedPath = "/Identity/Account/AccessDenied";
                })
                .AddCookie("PublicScheme", opt =>
                {
                    opt.Cookie.Name = "Auth.Public.Cookie";
                    opt.LoginPath = "/Account/Login";
                    opt.LogoutPath = "/Account/Logout";
                    opt.AccessDeniedPath = "/Account/AccessDenied";
                });

builder.Services.AddAuthorization(opt =>
{
    // For Admin Policy
    opt.AddPolicy("AdminPolicy", policy =>
    {
        policy.AddAuthenticationSchemes("AdminScheme");
        policy.RequireAuthenticatedUser();
    });

    // For Public Policy
    opt.AddPolicy("PublicPolicy", policy =>
    {
        policy.AddAuthenticationSchemes("PublicScheme");
        policy.RequireAuthenticatedUser();
    });
});

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

//builder.Services.ConfigureApplicationCookie(options =>
//{
//    options.Cookie.Name = "Auth.Admin.Cookie";
//});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication(); // Kimlik do�rulama
app.UseAuthorization();  // Yetkilendirme



app.MapControllerRoute(
    name: "area",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();



