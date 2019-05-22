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
		public class InputModel
		{
			[Display(Name = "Title"), Required(ErrorMessage = "Articles must have a title")]
			public string Title { get; set; }
			[Display(Name = "Content")]
			public string Content { get; set; }
		}

		[BindProperty]
		public InputModel Input { get; set; }
	}
}