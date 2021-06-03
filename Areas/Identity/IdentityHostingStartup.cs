using System;
using Asp.netAuthenticationSystem.Areas.Identity.Data;
using Asp.netAuthenticationSystem.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Asp.netAuthenticationSystem.Areas.Identity.IdentityHostingStartup))]
namespace Asp.netAuthenticationSystem.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AspnetAuthenticationSystemDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("AspnetAuthenticationSystemDbContextConnection")));

                // we are not going for the email confirmation then we can do options.SignIn.RequireConfirmedAccount = false
                services.AddDefaultIdentity<ApplicationUser>(options =>
                {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                }
            
                )
                    .AddEntityFrameworkStores<AspnetAuthenticationSystemDbContext>();
            });
        }
    }
}