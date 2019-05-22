using Microsoft.AspNetCore.Mvc;
using MTR2.Dal.Dtos;
using MTR2.Dal.Entities;
using MTR2.Dal.Services;
using MTR2.Dal.Users;
using System.Collections.Generic;
using System.Security.Claims;

namespace MTR2.Web.ViewComponents
{
	public class RepoArticleBigListViewComponent : ViewComponent
	{
		public class RepoArticleListModel {
			public IEnumerable<RepoArticleDto> RepoArticles { get; set; }
			public bool IsAdmin { get; set; }
		}
		public RepoArticleBigListViewComponent(RepoArticleService repoArticleService)
		{
			RepoArticleService = repoArticleService;
		}

		public RepoArticleService RepoArticleService { get; }
		public IViewComponentResult Invoke(ClaimsPrincipal claimsPrincipal)
		{
			var admin = claimsPrincipal.IsInRole(Roles.Administrators);
			return View(new RepoArticleListModel
			{
				RepoArticles=RepoArticleService.GetRepoArticles(),
				IsAdmin=admin
			});
		}
	}
}
