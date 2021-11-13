using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SignalRchatApp.Areas.Identity.Data;
using SignalRchatApp.Data;

[assembly: HostingStartup(typeof(SignalRchatApp.Areas.Identity.IdentityHostingStartup))]
namespace SignalRchatApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<SignalRchatDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("SignalRchatDbContextConnection")));

                services.AddDefaultIdentity<AppUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<SignalRchatDbContext>();
            });
        }
    }
}