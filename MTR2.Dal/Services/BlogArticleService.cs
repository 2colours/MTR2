using MTR2.Dal.Dtos;
using MTR2.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MTR2.Dal.Services
{
	public class BlogArticleService
	{
		public BlogArticleService(MTR2DbContext dbContext)
		{
			DbContext = dbContext;
		}
		public MTR2DbContext DbContext { get; }
		public static Expression<Func<BlogArticle, BlogArticleDto>> BlogArticleSelector { get; } = r => new BlogArticleDto
		{
			Content = r.Content,
			Author = r.Author,
			CreationDate = r.CreationDate,
			Title = r.Title
		};
		public IEnumerable<BlogArticleDto> GetBlogArticles() => DbContext.BlogArticles.Select(BlogArticleSelector).OrderByDescending(r => r.CreationDate);
		public BlogArticleDto GetBlogArticle(int id) => DbContext.BlogArticles.Where(r => r.Id == id).Select(BlogArticleSelector).FirstOrDefault();
	}
}
