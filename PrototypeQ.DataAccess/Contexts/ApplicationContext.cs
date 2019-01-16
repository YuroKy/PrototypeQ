using Microsoft.EntityFrameworkCore;

namespace PrototypeQ.DataAccess.Contexts
{
	public class ApplicationContext : DbContext
	{
		public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

	}
}
