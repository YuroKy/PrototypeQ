using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrototypeQ.DataAccess.Entities;

namespace PrototypeQ.DataAccess.Configurations
{
	public class PersonConfiguration : IEntityTypeConfiguration<PersonEntity>
	{
		public void Configure(EntityTypeBuilder<PersonEntity> builder)
		{
			builder
				.ToTable("People")
				.HasKey(x => x.Id);

			builder.Property(x => x.FirstName)
				.IsRequired();

			builder.Property(x => x.LastName)
				.IsRequired();

			builder.Property(x => x.Email)
				.IsRequired();

			builder.Property(x => x.Phone)
				.IsRequired();

			builder.Property(x => x.Age)
				.IsRequired();
		}
	}
}