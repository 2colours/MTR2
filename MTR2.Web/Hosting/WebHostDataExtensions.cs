﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MTR2.Dal.SeedInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MTR2.Web.Hosting
{
	public static class WebHostDataExtensions
	{
		public async static Task<IWebHost> MigrateDatabase<TContext>(this IWebHost host)
				where TContext : DbContext
		{
			using (var scope = host.Services.CreateScope())
			{
				var serviceProvider = scope.ServiceProvider;
				var context = serviceProvider.GetRequiredService<TContext>();
				context.Database.Migrate();

				var roleSeeder = serviceProvider.GetRequiredService<IRoleSeedService>();
				await roleSeeder.SeedRoleAsync();

				var userSeeder = serviceProvider.GetRequiredService<IUserSeedService>();
				await userSeeder.SeedUserAsync();
			}

			return host;
		}
	}
}
