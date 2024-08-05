using Microsoft.AspNetCore.Identity;

namespace GameGalaxy.Models
{
    public class ConfigureIdentity
    {
        public static async Task CreateRolesAsync(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            string[] roleNames = { "Admin", "Customer", "Employee" };

            foreach (var roleName in roleNames)
            {
                if (!await roleManager.RoleExistsAsync(roleName))
                {
                    await roleManager.CreateAsync(new IdentityRole(roleName));
                }
            }
        }
        public static async Task CreateAdminUserAsync(IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<User>>();

            string email = "administrator@example.com";
            string password = "Pa$$w0rd";
            string roleName = "Admin";

            var adminUser = await userManager.FindByEmailAsync(email);
            if (adminUser == null)
            {
                adminUser = new User
                {
                    UserName = email,
                    Email = email,
                    FirstName = "Admin",
                    LastName = "Istrator "
                };
                var result = await userManager.CreateAsync(adminUser, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(adminUser, roleName);
                }
            }
        }
        public static async Task CreateEmployeeUserAsync(IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<User>>();

            string email = "employee@example.com";
            string password = "Passw0rd ";
            string roleName = "Employee";

            var employeeUser = await userManager.FindByEmailAsync(email);
            if (employeeUser == null)
            {
                employeeUser = new User
                {
                    UserName = email,
                    Email = email,
                    FirstName = "Empl",
                    LastName = "Oyee"
                };
                var result = await userManager.CreateAsync(employeeUser, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(employeeUser, roleName);
                }
            }
        }

    }
}
