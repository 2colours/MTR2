using Microsoft.AspNetCore.Mvc;
using MTR2.Dal.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MTR2.Web.ViewComponents
{
	public class BlogArticleHeaderViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke(BlogArticleDto bookDto)
		{
			return View(bookDto);
		}
	}
}
