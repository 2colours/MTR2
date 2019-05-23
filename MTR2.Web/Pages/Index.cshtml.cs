using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Markdig;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MTR2.Web.Pages
{
	public class IndexModel : PageModel
	{
		public string RenderedContent { get; private set; }
		public IActionResult OnGet()
		{
			string text = System.IO.File.ReadAllText("~\\..\\Markdown\\Index.md");
			var pipeline = new MarkdownPipelineBuilder()
										.UseAdvancedExtensions()
										.Build();
			RenderedContent = Markdown.ToHtml(text,pipeline);
			return Page();
		}
	}
}
