using Microsoft.AspNetCore.Mvc;
using MTR2.Dal.Dtos;
using MTR2.Dal.Services;
using MTR2.Dal.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;

namespace MTR2.Web.ViewComponents
{
	public class RepoArticleBigListViewComponent : ViewComponent
	{
		public class RepoArticleBigListModel
		{
			public IEnumerable<RepoArticleDto> RepoArticles { get; set; }
			public bool IsAdmin { get; set; }
		}
		public RepoArticleBigListViewComponent(RepoArticleService repoArticleService)
		{
			RepoArticleService = repoArticleService;
		}

		public RepoArticleService RepoArticleService { get; }
		public IViewComponentResult Invoke(IPrincipal user)
		{
			return View(new RepoArticleBigListModel
			{
				RepoArticles = RepoArticleService.GetRepoArticles(),
				IsAdmin=user.IsInRole(Roles.Administrators)
			});
		}
	}
}
