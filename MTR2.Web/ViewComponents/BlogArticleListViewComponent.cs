using Microsoft.AspNetCore.Mvc;
using MTR2.Dal.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MTR2.Web.ViewComponents
{
	public class BlogArticleListViewComponent : ViewComponent
	{
		public BlogArticleListViewComponent(BlogArticleService blogArticleService)
		{
			BlogArticleService = blogArticleService;
		}

		public BlogArticleService BlogArticleService { get; }

		public IViewComponentResult Invoke()
		{
			return View(BlogArticleService.GetBlogArticles());
		}
	}
}
