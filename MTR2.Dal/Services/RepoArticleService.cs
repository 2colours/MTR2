using MTR2.Dal.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
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
		public IEnumerable<RepoArticleDto> GetRepoArticles() => DbContext.RepoArticles.Select(r => new RepoArticleDto
		{
			Content = r.Content,
			Id = r.Id,
			Order = r.Order,
			Title = r.Title
		}).OrderBy(r => r.Order);
	}
}
