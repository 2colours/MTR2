using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MTR2.Dal.Entities;
using MTR2.Dal.SeedInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTR2.Dal.EntityConfigurations
{
	public class RepoArticleEntityConfiguration : IEntityTypeConfiguration<RepoArticle>
	{
		private readonly ISeedService _seedService;

		public RepoArticleEntityConfiguration(ISeedService seedService)
			=> _seedService = seedService;
		public void Configure(EntityTypeBuilder<RepoArticle> builder)
			=> builder.HasData(_seedService.RepoArticles);
	}
}
