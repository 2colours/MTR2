﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MTR2.Dal.Entities;

namespace MTR2.Dal
{
	public class MTR2DbContext : IdentityDbContext<User, IdentityRole<int>, int>
	{
		public MTR2DbContext(DbContextOptions options) : base(options)
		{ }

		public DbSet<RepoArticle> RepoArticles { get; set; }
		public DbSet<BlogArticle> BlogArticles { get; set; }
		public DbSet<TodoItem> TodoItems { get; set; }
		public DbSet<IktaItem> IktaItems { get; set; }
		//TODO add quiz


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<User>().ToTable("Users");
			
		}
	}
}
