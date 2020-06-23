using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShopCET46.WEB.Data;
using ShopCET46.WEB.Data.Entities;
using ShopCET46.WEB.Helpers;

namespace ShopCET46.WEB
{
    public class Startup
    {
        public Startup(IConfiguration configuration) // injeçoes!!!
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddIdentity<User, IdentityRole>(cfg =>
            {
                cfg.User.RequireUniqueEmail = true;
                cfg.Password.RequireDigit = false; // qnd for a serio é True
                cfg.Password.RequiredUniqueChars = 0;
                cfg.Password.RequireLowercase = false;  // =
                cfg.Password.RequireNonAlphanumeric = false;  // =
                cfg.Password.RequireUppercase = false;  // =
                cfg.Password.RequiredLength = 6;
            })
                .AddEntityFrameworkStores<DataContext>();
            //objetos do core nao precisam de ser injetados


            //injeçoes ************************************************************************************************************* 
            //programaçao funcional com lambda atraves de injeção , logo no arranque!!
            services.AddDbContext<DataContext>(cfg =>
            {
                cfg.UseSqlServer(this.Configuration.GetConnectionString("DefaultConnection"));
            });

            //executa aqui/ injeta aqui
            services.AddTransient<SeedDB>(); // depois de usado, morre
                                             //injeta o interface para quando ele precisar instancia lo

            services.AddScoped<IUserHelper, UserHelper>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICountryRepository, CountryRepository>();

            //Outro scope: services.AddSingleton -> depois de usado nunca morre, fica sempre instanciado


            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
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
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
