using System;
using System.Collections.Generic;
using System.Text;
using MTR2.Dal.Dtos;

namespace MTR2.Dal.Entities
{
	public class RepoArticle
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Content { get; set; }
		public int Order { get; set; }

		public static explicit operator RepoArticle(RepoArticleDto v)
		=> new RepoArticle
		{
			Content = v.Content,
			Id = v.Id,
			Order = v.Order,
			Title = v.Title
		};
	}
}
