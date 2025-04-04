using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SerialMakerBlazor.Areas.Identity;
using SerialMakerBlazor.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerialMakerBlazor
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            //services.AddDefaultIdentity<Data.AppUser>(options => options.SignIn.RequireConfirmedAccount = true)
            //    .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddIdentity<Data.AppUser, IdentityRole>(option => option.SignIn.RequireConfirmedAccount = true)
   .AddEntityFrameworkStores<ApplicationDbContext>()
   .AddDefaultTokenProviders();
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<Data.AppUser>>();
            services.AddDatabaseDeveloperPageExceptionFilter();
            services.AddSingleton<WeatherForecastService>();
            services.AddScoped<Services.EncryptionService>();
            services.AddHttpClient();
            services.AddScoped(typeof(Repositories.IGenericRepo<>), typeof(Repositories.GenericRepo<>));
            services.AddScoped<Repositories.ICodingRepository, Repositories.CodingRepository>();
            services.AddScoped<BlazorGenericComponents.Services.QueryService>();
            services.AddScoped<BlazorGenericComponents.Services.ILanguageService, BlazorGenericComponents.Services.LanguageService>();
            services.AddScoped<BlazorGenericComponents.Services.ILoggerService, BlazorGenericComponents.Services.LoggerService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
            // Seed roles and claims
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var services = scope.ServiceProvider;
                SeedRolesAndClaims(services).Wait(); // Call the seed method
            }
        }
        private async Task SeedRolesAndClaims(IServiceProvider serviceProvider)
        {
            try
            {
                var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                var userManager = serviceProvider.GetRequiredService<UserManager<Data.AppUser>>();

                string[] roleNames = { "Admin", "Manager", "Accountant" };
                foreach (var roleName in roleNames)
                {
                    var roleExist = await roleManager.RoleExistsAsync(roleName);
                    if (!roleExist)
                    {
                        await roleManager.CreateAsync(new IdentityRole(roleName));
                    }
                }
                bool IsFirstAdd = false;
                var user = await userManager.FindByEmailAsync("mothanna_alassar@yahoo.com");
                if (user == null)
                {
                    user = new Data.AppUser { RoleName = "Admin", FullName = "Mothanna", UserName = "mothanna_alassar@yahoo.com", Email = "mothanna_alassar@yahoo.com", EmailConfirmed = true };
                    await userManager.CreateAsync(user, "Admin@123");
                    IsFirstAdd = true;
                }
                if (IsFirstAdd)
                {
                    await userManager.AddToRoleAsync(user, "Admin");
                }
                // In your main method or Startup.cs
                using (var context = new Data.ApplicationDbContext(Configuration))
                {
                    //context.Database.Migrate(); // Ensure the database is up to date
                    DataSeeder.Seed(context); // Seed the data with checks
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message + " " + ex.InnerException?.Message);
            }
           
            //
            //await userManager.AddClaimAsync(user, new Claim("CanAddUsers", "true")); // For Admin
            //await userManager.AddClaimAsync(user, new Claim("CanEditUsers", "true")); // For Editor
            //await userManager.AddClaimAsync(user, new Claim("CanDeleteUsers", "true")); // For Editor
            //await userManager.AddClaimAsync(user, new Claim("CanViewUsers", "true")); // For Viewer
        }
    }
}
