using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Markdig;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MTR2.Dal.Dtos;
using MTR2.Dal.Entities;
using MTR2.Dal.Services;

namespace MTR2.Web.Pages
{
	public class RArticleModel : PageModel
	{
		public RArticleModel(RepoArticleService repoArticleService, UserManager<User> userManager)
		{
			RepoArticleService = repoArticleService;
			UserManager = userManager;
		}
		public RepoArticleService RepoArticleService { get; }
		public UserManager<User> UserManager { get; }
		public RepoArticleDto RepoArticle { get; private set; }
		private int? currentUserId;
		public string RenderedContent { get; private set; }
		public int? CurrentUserId =>
User.Identity.IsAuthenticated ?
(currentUserId ?? (currentUserId = int.Parse(UserManager.GetUserId(User)))) : null;
		public ActionResult OnGet(int? id)
		{
			if (id == null)
				return RedirectToPage("/Repo");
			RepoArticle = RepoArticleService.GetRepoArticle(id.Value);

			if (RepoArticle == null)
				return NotFound();
			var pipeline = new MarkdownPipelineBuilder()
							.UseAdvancedExtensions()
							.Build();
			RenderedContent = Markdown.ToHtml(RepoArticle.Content, pipeline);
			return Page();
		}


	}
}