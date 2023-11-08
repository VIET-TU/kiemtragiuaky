using KiemtraGiuaKy.Models;
using Microsoft.EntityFrameworkCore;

namespace KiemtraGiuaKy.Data
{
    public class DbInitialzer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationContext(serviceProvider
            .GetRequiredService<DbContextOptions<ApplicationContext>>()))
            {
                context.Database.EnsureCreated();
                if (context.Roles.Any())
                {
                    return;
                }
                var roles = new Role[] {
                    new Role{RoleName="Admin"},
                    new Role{RoleName="Shop"},
                    new Role{RoleName="User"},
                };
                foreach (var role in roles)
                {
                    context.Roles.Add(role);
                }
                context.SaveChanges();

                var users = new User[]
                {
                    new User { UserName = "Viet Tu", RoleId= 1},
                    new User { UserName = "Viet B", RoleId= 2},
                    new User { UserName = "Viet C", RoleId= 3}

                };

                foreach (var user in users)
                {
                    context.Users.Add(user);
                }

                context.SaveChanges();


            }
        }
    }
}
