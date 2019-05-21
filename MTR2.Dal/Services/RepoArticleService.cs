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
		public IEnumerable<RepoArticleDto> GeRepoArticles() => DbContext.RepoArticles.Select(b => new RepoArticleDto
		{
			Content = b.Content,
			Id = b.Id,
			Order = b.Order,
			Title = b.Title
		});
	}
}
