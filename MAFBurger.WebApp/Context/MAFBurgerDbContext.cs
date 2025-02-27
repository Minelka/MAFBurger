using MAFBurger.WebApp.Data.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace MAFBurger.WebApp.Context;

public class MAFBurgerDbContext : IdentityDbContext<AppUser>
{
    public MAFBurgerDbContext(DbContextOptions<MAFBurgerDbContext> options)
        : base(options)
    {
    }

    public DbSet<Menu> Menus { get; set; }
    public DbSet<Extra> Extras { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderExtra> OrdersExtras { get; set; }
    public DbSet<OrderMenu> OrdersMenus { get; set; }
    public DbSet<IdentityRole> Roles { get; set; }
    public DbSet<Sauce> Sauces { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

        builder.ApplyConfigurationsFromAssembly(typeof(MAFBurgerDbContext).Assembly);
    }
}
