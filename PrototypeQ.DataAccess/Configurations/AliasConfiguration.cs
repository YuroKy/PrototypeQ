using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrototypeQ.Data.Entities;

namespace PrototypeQ.Data.Configurations
{
	class AliasConfiguration : IEntityTypeConfiguration<AliasEntity>
	{
		public void Configure(EntityTypeBuilder<AliasEntity> builder)
		{
			builder
				.ToTable("Aliases")
				.HasKey(x => x.Id);

			builder.Property(x => x.Name)
				.IsRequired();

			builder.Property(x => x.Alternatives)
				.IsRequired();
		}
	}
}
