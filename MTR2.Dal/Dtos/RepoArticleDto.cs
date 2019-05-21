using System;
using System.Collections.Generic;
using System.Text;

namespace MTR2.Dal.Dtos
{
	public class RepoArticleDto
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Content { get; set; }
		public int Order { get; set; }
	}
}
