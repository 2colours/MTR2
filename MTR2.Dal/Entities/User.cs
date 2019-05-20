using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTR2.Dal.Entities
{
	public class User : IdentityUser<int>
	{

		public ICollection<BlogArticle> Comments { get; set; }
		public string Name { get; set; }
		public ICollection<RepoArticle> Todos { get; set; }
		public ICollection<RepoArticle> Iktas { get; set; }
	}
}
