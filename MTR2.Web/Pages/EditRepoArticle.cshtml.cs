using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MTR2.Dal.Services;
using MTR2.Dal.Users;

namespace MTR2.Web.Pages
{
	public class EditRepoArticleModel : PageModel
	{
		public EditRepoArticleModel(RepoArticleService repoArticleService)
		{
			RepoArticleService = repoArticleService;
		}
		public RepoArticleService RepoArticleService { get; }
		public void OnGet()
		{
			if (!PageContext.HttpContext.User.IsInRole(Roles.Administrators))
			{
				RedirectToPage("/Repo");
				return;
			}

		}
	}
}