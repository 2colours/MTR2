using System;
using System.Collections.Generic;
using System.Text;

namespace MTR2.Dal.Entities
{
	public class BlogArticle
	{
		public int Id { get; set; }
		public int AuthorId { get; set; }
		public User Author { get; set; }
		public DateTimeOffset CreationDate { get; set; }
		public string Title { get; set; }
		public string Content { get; set; }
	}
}
