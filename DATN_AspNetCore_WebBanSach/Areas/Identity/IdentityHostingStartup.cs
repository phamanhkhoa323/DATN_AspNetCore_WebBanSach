using System;
using DATN_AspNetCore_WebBanSach.Areas.Identity.Data;
using DATN_AspNetCore_WebBanSach.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(DATN_AspNetCore_WebBanSach.Areas.Identity.IdentityHostingStartup))]
namespace DATN_AspNetCore_WebBanSach.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<DATN_AspNetCore_WebBanSachContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("DATN_AspNetCore_WebBanSachContextConnection")));

                services.AddDefaultIdentity<DATN_AspNetCore_WebBanSachUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<DATN_AspNetCore_WebBanSachContext>();
            });
        }
    }
}