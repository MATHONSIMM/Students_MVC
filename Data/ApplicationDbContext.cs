//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore;

//namespace Students_MVC.Data
//{
//    public class ApplicationDbContext : IdentityDbContext
//    {
//        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
//            : base(options)
//        {
//        }
//    }
//}

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Students_MVC.Models;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<IdentityRole>().ToTable("MappingListRoles");
        builder.Entity<IdentityUser<string>>().ToTable("MappingListUsers");
        builder.Entity<IdentityUserRole<string>>().ToTable("MappingListUserRoles");
        builder.Entity<IdentityUserClaim<string>>().ToTable("MappingListUserClaims");
        builder.Entity<IdentityUserLogin<string>>().ToTable("MappingListUserLogins");
        builder.Entity<IdentityUserToken<string>>().ToTable("MappingListUserTokens");
        builder.Entity<IdentityRoleClaim<string>>().ToTable("MappingListRoleClaims");
    }
}
