using KiemtraGiuaKy.Models;
using Microsoft.EntityFrameworkCore;

namespace KiemtraGiuaKy.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

             public virtual DbSet<User> Users { get; set; }

             public virtual DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().ToTable(nameof(Role));
            modelBuilder.Entity<User>().ToTable(nameof(User));
        }
    }
}
