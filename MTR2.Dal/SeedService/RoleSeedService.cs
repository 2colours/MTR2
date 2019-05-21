using Microsoft.AspNetCore.Identity;
using MTR2.Dal.SeedInterfaces;
using MTR2.Dal.Users;
using System.Threading.Tasks;

namespace MTR2.Dal.SeedService
{
	public class RoleSeedService : IRoleSeedService
	{
		private readonly RoleManager<IdentityRole<int>> _roleManager;
		public RoleSeedService(RoleManager<IdentityRole<int>> roleManager) =>
			_roleManager = roleManager;
		public async Task SeedRoleAsync()
		{
			if (!await _roleManager.RoleExistsAsync(Roles.Administrators))
				await _roleManager.CreateAsync(new IdentityRole<int> { Name = Roles.Administrators });
		}
	}
}
