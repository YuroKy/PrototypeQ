using Microsoft.EntityFrameworkCore;
using PrototypeQ.DataAccess.Configurations;
using PrototypeQ.DataAccess.Entities;

namespace PrototypeQ.DataAccess.Contexts
{
	public class ApplicationContext : DbContext
	{
		public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new PersonConfiguration());
		}

		public DbSet<Person> People { get; set; }
	}
}
