using Microsoft.AspNetCore.Identity;
using MTR2.Dal.Entities;
using MTR2.Dal.SeedInterfaces;
using MTR2.Dal.Users;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTR2.Dal.SeedService
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
					Email = "admin@mtr2.hu",
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
