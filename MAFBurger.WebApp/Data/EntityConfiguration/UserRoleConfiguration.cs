using MAFBurger.WebApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MAFBurger.WebApp.Data.EntityConfiguration
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(new IdentityUserRole<string>
            {
                RoleId = "329d3be5-8001-4997-85a9-ebc16be771c2",
                UserId = "252d1809-cd07-4ebd-87d1-83cefac3b78c",
            });

            builder.HasData(new IdentityUserRole<string>
            {
                RoleId = "c9bbce7e-7372-47f2-80e9-029ce117f245",
                UserId = "777d1907-cd07-4ebd-87f1-83fecac3b78c",
            });
        }
    }
}
