using MTR2.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTR2.Dal.SeedInterfaces
{
    public interface ISeedService
    {
		IList<RepoArticle> RepoArticles { get; }
		IList<BlogArticle> BlogArticles { get; }
    }
}
