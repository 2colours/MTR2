using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MTR2.Dal.Entities;
using MTR2.Dal.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MTR2.Web.Controllers
{
	[Route("[controller]/[action]")]
	public class ArticleController : Controller
	{
		public ArticleController(RepoArticleService repoArticleService)
		{
			RepoArticleService = repoArticleService;
		}
		public RepoArticleService RepoArticleService { get; }
		public IActionResult DeleteRepoArticle(int id)
		{
			RepoArticleService.DeleteRepoArticle(id);
			return RedirectToPage("/Repo");
		}
	}
}
