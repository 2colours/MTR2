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
		public static Expression<Func<BlogArticle, BlogArticleDto>> BlogArticleSelector { get; } = b => new BlogArticleDto
		{
			Content = b.Content,
			Author = b.Author,
			CreationDate = b.CreationDate,
			Title = b.Title,
			Id=b.Id,
			ShortDescription=b.ShortDescription
		};
		public IEnumerable<BlogArticleDto> GetBlogArticles() => DbContext.BlogArticles.Select(BlogArticleSelector).OrderByDescending(r => r.CreationDate);
		public BlogArticleDto GetBlogArticle(int id) => DbContext.BlogArticles.Where(r => r.Id == id).Select(BlogArticleSelector).FirstOrDefault();
	}
}
