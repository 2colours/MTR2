using MTR2.Dal.Dtos;
using MTR2.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MTR2.Dal.Services
{
	public class RepoArticleService
	{
		public RepoArticleService(MTR2DbContext dbContext)
		{
			DbContext = dbContext;
		}
		public MTR2DbContext DbContext { get; }
		public static Expression<Func<RepoArticle, RepoArticleDto>> RepoArticleSelector { get; } = r => new RepoArticleDto
		{
			Content = r.Content,
			Id = r.Id,
			Order = r.Order,
			Title = r.Title
		};
		public IEnumerable<RepoArticleDto> GetRepoArticles() => DbContext.RepoArticles.Select(RepoArticleSelector).OrderBy(r => r.Order);
		public RepoArticleDto GetRepoArticle(int id) => DbContext.RepoArticles.Where(r => r.Id == id).Select(RepoArticleSelector).FirstOrDefault();
		public void DeleteRepoArticle(int id) {
			var repoArticle=DbContext.RepoArticles.Where(r => r.Id == id).First();
			if (repoArticle == null)
				return;
			DbContext.RepoArticles.Remove(repoArticle);
			DbContext.SaveChanges();
		}
		public void EditRepoArticle(RepoArticleDto repoArticle)
		{
			var article = DbContext.RepoArticles.Where(a=>a.Id==repoArticle.Id).First();
			if (article == null)
				return;
			article.Content = repoArticle.Content;
			article.Title = repoArticle.Title;
			article.Order = repoArticle.Order;
			DbContext.SaveChanges();
		}
	}
}
