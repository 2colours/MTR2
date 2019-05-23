using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MTR2.Dal;
using MTR2.Dal.Entities;
using MTR2.Dal.SeedInterfaces;
using MTR2.Dal.SeedService;
using MTR2.Dal.Services;

namespace MTR2.Web
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddScoped<IRoleSeedService, RoleSeedService>();
			services.AddScoped<IUserSeedService, UserSeedService>();
			services.AddScoped<RepoArticleService>();
			services.AddScoped<BlogArticleService>();
			services.AddIdentity<User, IdentityRole<int>>()
							.AddEntityFrameworkStores<MTR2DbContext>()
							.AddDefaultTokenProviders();
			services.AddDbContext<MTR2DbContext>(o=>o.UseSqlServer(
				Configuration.GetConnectionString(nameof(MTR2DbContext))));
			services.AddTransient<ISeedService, SeedService>();
			services.Configure<CookiePolicyOptions>(options =>
			{
				// This lambda determines whether user consent for non-essential cookies is needed for a given request.
				options.CheckConsentNeeded = context => true;
				options.MinimumSameSitePolicy = SameSiteMode.None;
			});


			services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
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
				app.UseExceptionHandler("/Error");
			}

			app.UseStaticFiles();
			app.UseCookiePolicy();
			app.UseAuthentication();
			app.UseMvc();
		}
	}
}
