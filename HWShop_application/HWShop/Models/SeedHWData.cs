using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace HWShop.Models
{
    public class SeedHWData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            HardWareDBContext context = app.ApplicationServices
                .GetRequiredService<HardWareDBContext>();
            context.Database.Migrate();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Ryzen-3600",
                        Description = "Desktop CPU(3.6-4.2 Mhz)",
                        Category = "CPU",
                        Price = 219.99m,
                        Amount = 15
                    },
                    new Product
                    {
                        Name = "Asus TUF RTX 3070",
                        Description = "High performance gaming GPU",
                        Category = "GPU",
                        Price = 1699.99m
                    },
                    new Product
                    {
                        Name = "Asus B550-m-a",
                        Description = "A motherboard for 3d ryzen gen. ",
                        Category = "MotherBoard",
                        Price = 149.99m
                    },
                    new Product
                    {
                        Name = "DeepCool dq750st",
                        Description = "PowerSupply for gaming desktops(750w)",
                        Category = "PowerSupply",
                        Price = 99.99m
                    },
                    new Product
                    {
                        Name = "Hyperx Predator (3200mhz)",
                        Description = "A pair of fast RAM memory",
                        Category = "RAM",
                        Price = 79.99m
                    },
                    new Product
                    {
                        Name = "Adata XPG 1tb",
                        Description = "Fast NVME storage",
                        Category = "Storage",
                        Price = 89.99m
                    }
                    
                );
                context.SaveChanges();
            }
        }
    }
}
