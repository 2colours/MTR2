using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MTR2.Dal.Entities;
using MTR2.Dal.SeedInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTR2.Dal.EntityConfigurations
{
	public class BlogArticleEntityConfiguration : IEntityTypeConfiguration<BlogArticle>
	{
		private readonly ISeedService _seedService;

		public BlogArticleEntityConfiguration(ISeedService seedService)
			=> _seedService = seedService;
		public void Configure(EntityTypeBuilder<BlogArticle> builder)
			=> builder.HasData(_seedService.BlogArticles);
	}
}
