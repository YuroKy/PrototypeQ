using Microsoft.EntityFrameworkCore;
using PrototypeQ.DataAccess.Entities;

namespace PrototypeQ.DataAccess.Contexts
{
	public class ApplicationContext : DbContext
	{
		public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
		public DbSet<Person> People { get; set; }
	}
}
