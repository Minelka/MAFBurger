using MAFBurger.WebApp.Data.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MAFBurger.WebApp.Data.EntityConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            var hasher = new PasswordHasher<AppUser>();

            builder.HasData(new AppUser
            {
                Id = "252d1809-cd07-4ebd-87d1-83cefac3b78c",
                UserName = "admin@gmail.com",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                Email = "admin@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(new AppUser() { Id= "252d1809-cd07-4ebd-87d1-83cefac3b78c" }, "123456*Admin"),
                SecurityStamp = "87b82a5e-69c1-4831-87d0-678b208084ae",
                ConcurrencyStamp = "55c5fc1a-1d71-4de4-b65e-e14eed798ade",
                LockoutEnabled = false
            });

            builder.HasData(new AppUser
            {
                Id = "777d1907-cd07-4ebd-87f1-83fecac3b78c",
                UserName = "customer@gmail.com",
                NormalizedUserName = "CUSTOMER@GMAIL.COM",
                Email = "customer@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(new AppUser() { Id = "777d1907-cd07-4ebd-87f1-83fecac3b78c" }, "123456*Customer"),
                SecurityStamp = "50b82a5e-69c1-4831-87d0-678b208084ae",
                ConcurrencyStamp = "60c5fc1a-1d71-4de4-b65e-e14eed798ade",
                LockoutEnabled = false
            });
        }
    }
}
