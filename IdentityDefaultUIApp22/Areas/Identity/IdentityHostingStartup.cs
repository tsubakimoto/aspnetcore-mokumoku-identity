using System;
using IdentityDefaultUIApp22.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(IdentityDefaultUIApp22.Areas.Identity.IdentityHostingStartup))]
namespace IdentityDefaultUIApp22.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<IdentityCustomUIApp22Context>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("IdentityCustomUIApp22ContextConnection")));

                services.AddIdentity<IdentityUser, IdentityRole>()
                    .AddDefaultUI(UIFramework.Bootstrap4)
                    .AddEntityFrameworkStores<IdentityCustomUIApp22Context>();
            });
        }
    }
}