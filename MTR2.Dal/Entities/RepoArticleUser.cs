using System;
using System.Collections.Generic;
using System.Text;

namespace MTR2.Dal.Entities
{
	public class RepoArticleUser
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public User User { get; set; }
		public int RepoArticleId { get; set; }
		public RepoArticle RepoArticle { get; set; }
	}
}
