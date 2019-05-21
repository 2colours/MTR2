using Microsoft.AspNetCore.Mvc;
using MTR2.Dal.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MTR2.Web.ViewComponents
{
	public class RepoArticleListViewComponent : ViewComponent
	{
		public RepoArticleListViewComponent(RepoArticleService repoArticleService)
		{
			RepoArticleService = repoArticleService;
		}

		public RepoArticleService RepoArticleService { get; }
		public IViewComponentResult Invoke()
		{
			return View(RepoArticleService.GetRepoArticles());
		}
	}
}
