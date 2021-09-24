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
	internal class UserDetailFluentConfiguration : IEntityTypeConfiguration<UserDetail>
	{
		public void Configure(EntityTypeBuilder<UserDetail> builder)
		{
			builder.HasData(data: UserDetailSeedData.GetUsersDetails());
		}
	}
}
