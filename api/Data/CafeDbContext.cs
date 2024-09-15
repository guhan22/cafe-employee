using CafeApi.Models.Dbo;
using Microsoft.EntityFrameworkCore;

namespace CafeApi.Data
{
	public class CafeDbContext : DbContext
	{
		private readonly IConfiguration configuration;
		public DbSet<Cafe> Cafe { get; set; }
		public DbSet<Employee> Employee { get; set; }

		public CafeDbContext(IConfiguration _configuration)
		{
			configuration = _configuration;
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseMySQL(configuration.GetSection("ConnectionString").Value ?? string.Empty);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Cafe>(entity =>
			{
				entity.HasKey(e => e.Id);
				entity.Property(e => e.Name).IsRequired();
			});

			modelBuilder.Entity<Employee>(entity =>
			{
				entity.HasKey(e => e.Id);
				entity.Property(e => e.Name).IsRequired();
				//entity.HasOne(d => d.Publisher)
				//  .WithMany(p => p.Books);
			});
		}
	}
}
