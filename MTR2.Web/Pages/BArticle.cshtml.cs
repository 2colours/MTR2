using Markdig;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MTR2.Dal.Dtos;
using MTR2.Dal.Entities;
using MTR2.Dal.Services;

namespace MTR2.Web.Pages
{
	public class BArticleModel : PageModel
	{
		public BArticleModel(BlogArticleService blogArticleService, UserManager<User> userManager)
		{
			BlogArticleService = blogArticleService;
			UserManager = userManager;
		}
		public BlogArticleService BlogArticleService { get; }
		public UserManager<User> UserManager { get; }
		public BlogArticleDto BlogArticle { get; private set; }
		private int? currentUserId;
		public string RenderedContent { get; private set; }
		public int? CurrentUserId =>
User.Identity.IsAuthenticated ?
(currentUserId ?? (currentUserId = int.Parse(UserManager.GetUserId(User)))) : null;
		public ActionResult OnGet(int? id)
		{
			if (id == null)
				return RedirectToPage("/Posts");
			BlogArticle = BlogArticleService.GetBlogArticle(id.Value);

			if (BlogArticle == null)
				return NotFound();
			var pipeline = new MarkdownPipelineBuilder()
							.UseAdvancedExtensions()
							.Build();
			RenderedContent = Markdown.ToHtml(BlogArticle.Content, pipeline);
			return Page();
		}


	}
}