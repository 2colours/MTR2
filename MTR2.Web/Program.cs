using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MTR2.Dal;
using MTR2.Web.Hosting;

namespace MTR2.Web
{
	public class Program
	{
		public static async Task Main(string[] args)
		{
			(await CreateWebHostBuilder(args)
				.Build()
				.MigrateDatabase<MTR2DbContext>())
				.Run();
		}

		public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
			WebHost.CreateDefaultBuilder(args)
				.UseStartup<Startup>();
	}
}
