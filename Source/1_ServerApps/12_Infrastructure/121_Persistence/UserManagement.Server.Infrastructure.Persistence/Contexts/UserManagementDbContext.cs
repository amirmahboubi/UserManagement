using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Server.Core.Domain.Entities;

namespace UserManagement.Server.Infrastructure.Persistence.Contexts
{
	public class UserManagementDbContext : DbContext
	{
		public UserManagementDbContext([NotNullAttribute] DbContextOptions options) : base(options)
		{
		}

		public DbSet<User> Users { get; set; }
		public DbSet<UserDetail> UserDetails { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(assembly: Assembly.GetExecutingAssembly());
			base.OnModelCreating(modelBuilder);
		}
	}
}
