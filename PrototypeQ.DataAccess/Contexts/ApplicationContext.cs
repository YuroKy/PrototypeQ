using Microsoft.EntityFrameworkCore;
using PrototypeQ.Data.Configurations;
using PrototypeQ.Data.Entities;

namespace PrototypeQ.Data.Contexts
{
	public class ApplicationContext : DbContext
	{
		public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new PersonConfiguration());
			modelBuilder.ApplyConfiguration(new AliasConfiguration());
		}

		public DbSet<PersonEntity> People { get; set; }
		public DbSet<AliasEntity> Aliases { get; set; }
	}
}
