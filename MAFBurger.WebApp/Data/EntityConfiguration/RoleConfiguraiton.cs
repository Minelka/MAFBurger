using MAFBurger.WebApp.Data.Concrete;
using MAFBurger.WebApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MAFBurger.WebApp.Data.EntityConfiguration
{
    public class RoleConfiguraiton : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.HasData(new AppRole
            {
                Id = "329d3be5-8001-4997-85a9-ebc16be771c2",
                Name = "Admin",
                NormalizedName = "ADMIN"

            });

            builder.HasData(new AppRole
            {
                Id = "c9bbce7e-7372-47f2-80e9-029ce117f245",
                Name = "Customer",
                NormalizedName = "CUSTOMER"

            });
        }
    }
}
