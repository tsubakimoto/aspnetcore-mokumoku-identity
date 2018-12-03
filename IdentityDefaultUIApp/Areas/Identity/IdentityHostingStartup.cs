using System;
using IdentityDefaultUIApp.Areas.Identity.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(IdentityDefaultUIApp.Areas.Identity.IdentityHostingStartup))]
namespace IdentityDefaultUIApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<IdentityDefaultUIAppIdentityDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("IdentityDefaultUIAppIdentityDbContextConnection")));

                services.AddDefaultIdentity<IdentityUser>()
                    .AddEntityFrameworkStores<IdentityDefaultUIAppIdentityDbContext>();

                // or

                //services.AddIdentity<IdentityUser, IdentityRole>()
                //    .AddDefaultUI()
                //    .AddEntityFrameworkStores<IdentityDefaultUIAppIdentityDbContext>();
            });
        }
    }
}