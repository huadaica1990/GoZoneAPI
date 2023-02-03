using GoZone.BackendServer.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GoZone.BackendServer.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>()
                .Property(x => x.Id)
                .HasMaxLength(50)
                .IsUnicode(false);
            builder.Entity<AppUser>()
                .Property(x => x.Id)
                .HasMaxLength(50)
                .IsUnicode(false);
            builder.Entity<Permission>()
                .HasKey(c => new { c.RoleId, c.FunctionId, c.CommandId });
            builder.Entity<CommandInFunction>()
                       .HasKey(c => new { c.CommandId, c.FunctionId });

            builder.Entity<ProductInCategory>()
                        .HasKey(c => new { c.ProductId, c.ProductCategoryId });
            builder.Entity<ProductCategoryTranslate>()
                        .HasKey(c => new { c.LanguageId, c.ProductCategoryId });
            builder.Entity<ProductTranslate>()
                        .HasKey(c => new { c.LanguageId, c.ProductId });
            builder.Entity<StaticPageTranslate>()
                        .HasKey(c => new { c.LanguageId, c.StaticPageId });

            builder.HasSequence("ProductSequence");
            builder.HasSequence("ProductCategorySequence");
            builder.HasSequence("StaticPageSequence");
        }
        #region User
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Function> Functions { get; set; }
        public DbSet<Command> Commands { get; set; }
        public DbSet<CommandInFunction> CommandInFunctions { get; set; }
        #endregion
        #region Other
        public DbSet<SystemConfig> SystemConfigs { get; set; }
        public DbSet<ActivityLog> ActivityLogs { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<StaticPage> StaticPages { get; set; }
        public DbSet<StaticPageTranslate> StaticPageTranslates { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<AnnouncementUser> AnnouncementUsers { get; set; }
        #endregion
        #region Order
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderImage> OrderImages { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        #endregion
        #region Product
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductTranslate> ProductTranslates { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductCategoryTranslate> ProductCategoryTranslates { get; set; }
        public DbSet<ProductInCategory> ProductInCategories { get; set; }
        #endregion
    }
}
