using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MTR2.Dal.Entities;
using MTR2.Dal.EntityConfigurations;
using MTR2.Dal.SeedInterfaces;

namespace MTR2.Dal
{
	public class MTR2DbContext : IdentityDbContext<User, IdentityRole<int>, int>
	{
		private readonly ISeedService _seedService;
		public MTR2DbContext(DbContextOptions options, ISeedService seedService) : base(options)
			=> _seedService = seedService;
		public DbSet<RepoArticle> RepoArticles { get; set; }
		public DbSet<BlogArticle> BlogArticles { get; set; }
		public DbSet<TodoItem> TodoItems { get; set; }
		public DbSet<IktaItem> IktaItems { get; set; }
		//TODO add quiz


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.ApplyConfiguration(new RepoArticleEntityConfiguration(_seedService));
			//modelBuilder.ApplyConfiguration(new BlogArticleEntityConfiguration(_seedService));
			modelBuilder.Entity<User>().ToTable("Users");
		}
	}
}
