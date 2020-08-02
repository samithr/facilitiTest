using InventoryApp.MVC.Areas.Identity.Data;
using InventoryApp.MVC.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(InventoryApp.MVC.Areas.Identity.IdentityHostingStartup))]
namespace InventoryApp.MVC.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<FacilitTestDbContextContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("FacilitTestDbContextContextConnection")));


                // setting email confirmation to alse since this is a sample application
                services.AddDefaultIdentity<InventoryAppCUser>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<FacilitTestDbContextContext>();
            });
        }
    }
}