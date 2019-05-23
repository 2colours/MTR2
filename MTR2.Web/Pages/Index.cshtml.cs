using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Markdig;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MTR2.Dal.Dtos;
using MTR2.Dal.Services;

namespace MTR2.Web.Pages
{
	public class IndexModel : PageModel
	{
		public IndexModel(BlogArticleService blogArticleService)
		{
			BlogArticleService = blogArticleService;
		}
		public BlogArticleService BlogArticleService { get; }
		public string RenderedContent { get; private set; }
		public IEnumerable<BlogArticleDto> BlogArticles { get; set; }
		public IActionResult OnGet()
		{
			string text = System.IO.File.ReadAllText("~\\..\\Markdown\\Index.md");
			var pipeline = new MarkdownPipelineBuilder()
										.UseAdvancedExtensions()
										.Build();
			RenderedContent = Markdown.ToHtml(text, pipeline);
			BlogArticles = BlogArticleService.GetBlogArticles();
			return Page();
		}
	}
}
