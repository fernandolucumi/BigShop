
namespace BigShop.Web.Data
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Entities;
    using Microsoft.AspNetCore.Identity;
    using Helpers;

    public class SeedDB
    {
        private readonly DataContext _context;
 
        private readonly IUserHelper userHelper;

        private readonly Random random;
        public SeedDB(DataContext context, IUserHelper userHelper)
        {
            _context = context;
            this.userHelper = userHelper;
            this.random = new Random();
        }
        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();

            var user = await this.userHelper.GetUserByEmailAsync("fernandolucumi@gmail.com");
            if (user == null)
            {
                user = new User
                {
                    FirstName = "Fernando",
                    LastName = "Lucumí",
                    Email = "fernandolucumi@gmail.com",
                    UserName = "fernandolucumi@gmail.com",
                    PhoneNumber = "3175154641"
                };

                var result = await this.userHelper.AddUserAsync(user, "123456");
                if (result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("It could not create the user in seeder");
                }
            }


            if (!_context.Products.Any())
            {
                this.AddProduct("iPhone x", user);
                this.AddProduct("Magic Mouse", user);
                this.AddProduct("iWatch Series 4", user);
                await _context.SaveChangesAsync();
            }
        }

        private void AddProduct(string name, User user)
        {
            _context.Products.Add(new Product
            {
                Name = name,
                Price = this.random.Next(1000),
                IsAvailable = true,
                Stock = this.random.Next(100),
                User = user
            });
        }
    }
}

