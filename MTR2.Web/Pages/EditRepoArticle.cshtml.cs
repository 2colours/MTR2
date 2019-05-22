using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MTR2.Dal.Dtos;
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
		public RepoArticleDto RepoArticle { get; private set; }
		public ActionResult OnGet(int id)
		{
			if (!PageContext.HttpContext.User.IsInRole(Roles.Administrators))
				return RedirectToPage("/Repo");
			RepoArticle = RepoArticleService.GetRepoArticle(id);
			return Page();

		}

		public ActionResult OnPost(string title,string content)
		{
			if (!PageContext.HttpContext.User.IsInRole(Roles.Administrators))
				return RedirectToPage("/Repo");
			RepoArticle.Title = title;
			RepoArticle.Content = content;
			RepoArticleService.EditRepoArticle(RepoArticle);
			return Page();
		}

	}
}