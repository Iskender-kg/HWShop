using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HWShop.Models;
using Microsoft.EntityFrameworkCore;
using HWShop.Models.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace HWShop
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<HardWareDBContext>(options => options.UseSqlServer(Configuration["Data:HWShopProducts:ConnectionString"]));
            services.AddDbContext<AppIdentityDbContext>(options => options.UseSqlServer(Configuration["Data:HWShopIdentity:ConnectionString"]));
            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<AppIdentityDbContext>().AddDefaultTokenProviders();

            services.AddTransient<IProductRepository, EFProductRepository>();
            services.AddControllersWithViews();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {


                endpoints.MapControllerRoute(
                    name: null,
                    pattern: "Admin",
                    defaults: new { controller = "Admin", action = "ProductList" });
                endpoints.MapControllerRoute(
                    name: null,
                    pattern: "{category}/Page{productpage:int}",
                    defaults: new { controller = "Products", action = "ProductList" }
                );

                endpoints.MapControllerRoute(
                    name: null,
                    pattern: "Page{productpage:int}",
                    defaults: new { controller = "Products", action = "ProductList", productpage = 1 }
                );

                endpoints.MapControllerRoute(
                    name: null,
                    pattern: "{category}",
                    defaults: new { controller = "Products", action = "ProductList", productpage = 1 }
                );
                endpoints.MapControllerRoute(
                    name: null,
                    pattern: "",
                    defaults: new { controller = "Products", action = "ProductList", productpage = 1 });
                endpoints.MapControllerRoute(
                    name: null,
                    pattern: "Products/Page{productpage}",
                    defaults: new { controller = "Products", action = "ProductList" }
                    );
                endpoints.MapControllerRoute(
                    name: null,
                    pattern: "{controller=Products}/{action=ProductList}/{id?}");
                endpoints.MapControllerRoute(
                    name: null,
                    pattern: "{controller=Admin}/{action=ProductList}/{id?}");
            });
            SeedHWData.EnsurePopulated(app);
            IdentitySeedData.EnsurePopulated(app);
        }
    }
}
