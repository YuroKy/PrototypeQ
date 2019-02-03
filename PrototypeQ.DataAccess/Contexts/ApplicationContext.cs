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
		}

		public DbSet<PersonEntity> People { get; set; }
	}
}
