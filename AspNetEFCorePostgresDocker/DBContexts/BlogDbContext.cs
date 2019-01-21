using Microsoft.EntityFrameworkCore;

namespace AspNetEFCorePostgresDocker
{

	public class BlogDbContext : DbContext
	{
		public BlogDbContext(DbContextOptions<BlogDbContext> options)
	   : base(options)
		{

		}
		public DbSet<Blog> Blogs { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			new BlogMap(modelBuilder.Entity<Blog>());
		}
	}

}
