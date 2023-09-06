using Microsoft.EntityFrameworkCore;
using WebApplication11.Data.Entity;

namespace WebApplication11.Data
{
    public class MyShopDataContextcs:DbContext
    {
        public MyShopDataContextcs(DbContextOptions<MyShopDataContextcs> opt):base(opt) 
        {
            
        }
        public DbSet<Cart> Carts { get; set; }  
        public DbSet<Category> Categories { get; set; } 
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }  
        public DbSet<Vendor> Vendor { get; set; }
        

    }
}
