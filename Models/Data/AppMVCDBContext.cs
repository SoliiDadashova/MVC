using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebAppMVC.Models.Data
{
    public class AppMVCDBContext:DbContext
    {
        public AppMVCDBContext(DbContextOptions<AppMVCDBContext> options):base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }

}
