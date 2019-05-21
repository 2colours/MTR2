using BookShop.Dal.Entities;
using BookShop.Dal.SeedInterfaces;
using BookShop.Dal.Users;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Dal.SeedService
{
	public class UserSeedService : IUserSeedService
	{
		private readonly UserManager<User> _userManager;
		public UserSeedService(UserManager<User> userManager) =>
			_userManager = userManager;
		public async Task SeedUserAsync()
		{
			if (!(await _userManager.GetUsersInRoleAsync(Roles.Administrators)).Any())
			{
				var user = new User
				{
					Email = "admin@bookshop.hu",
					UserName = "admin",
					SecurityStamp = Guid.NewGuid().ToString(),
					Name = "Adminisztrátor"
				};
				var createResult = await _userManager.CreateAsync(user, "$Administrator123");
				var addToRoleResult = await _userManager.AddToRoleAsync(user, Roles.Administrators);
				if (!createResult.Succeeded || !addToRoleResult.Succeeded)
					throw new ApplicationException($"Administrator could not be created: " +
							$"{string.Join(", ", createResult.Errors.Concat(addToRoleResult.Errors).Select(e => e.Description))}");
			}
		}
	}
}
