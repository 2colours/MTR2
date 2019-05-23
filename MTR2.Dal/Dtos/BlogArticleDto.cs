using MTR2.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTR2.Dal.Dtos
{
	public class BlogArticleDto
	{
		public int Id { get; set; }
		public User Author { get; set; }
		public DateTimeOffset CreationDate { get; set; }
		public string Title { get; set; }
		public string Content { get; set; }
	}
}
