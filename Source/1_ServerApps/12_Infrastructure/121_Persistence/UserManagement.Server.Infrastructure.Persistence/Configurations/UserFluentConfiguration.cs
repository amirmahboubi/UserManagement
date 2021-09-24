using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Server.Core.Domain.Entities;
using UserManagement.Server.Core.Domain.SeedData;

namespace UserManagement.Server.Infrastructure.Persistence.Configurations
{
	internal class UserFluentConfiguration : IEntityTypeConfiguration<User>
	{
		public void Configure(EntityTypeBuilder<User> builder)
		{
			builder.Property(p => p.UserName).IsRequired();
			builder.Property(p => p.Password).IsRequired();
			builder.HasData(data: UserSeedData.GetUsers());
		}
	}
}
