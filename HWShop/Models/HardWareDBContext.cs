using Microsoft.EntityFrameworkCore;

namespace HWShop.Models
{
    public class HardWareDBContext:DbContext
    {
        public HardWareDBContext(DbContextOptions<HardWareDBContext> options): base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
