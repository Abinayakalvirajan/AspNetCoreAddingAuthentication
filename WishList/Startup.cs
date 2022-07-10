using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WishList.Data;
using WishList.Models;

namespace WishList
{
@@ -14,6 +16,7 @@ public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<ApplicationDbContext>(options => options.UseInMemoryDatabase("Wishlist"));
            services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
@@ -28,6 +31,7 @@ public void Configure(IApplicationBuilder app, IHostingEnvironment env)
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseAuthentication();
            app.UseMvcWithDefaultRoute();
        }
    }
