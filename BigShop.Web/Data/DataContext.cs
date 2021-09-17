namespace BigShop.Web.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using BigShop.Web.Data.Entities;
    public class DataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        //public DbSet<Country> Countries { get; set; }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }
    }
}

