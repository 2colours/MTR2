﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MTR2.Dal.Entities
{
	public class RepoArticle
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Content { get; set; }
		public int Order { get; set; }
	}
}
