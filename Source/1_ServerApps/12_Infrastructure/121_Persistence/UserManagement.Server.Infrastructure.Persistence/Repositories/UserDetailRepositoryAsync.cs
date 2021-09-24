using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Server.Core.Application.Interfaces.IPersistenceRepositories;
using UserManagement.Server.Core.Domain.Entities;
using UserManagement.Server.Infrastructure.Persistence.Contexts;

namespace UserManagement.Server.Infrastructure.Persistence.Repositories
{
	public class UserDetailRepositoryAsync : GenericRepositoryAsync<UserDetail>, IUserDetailRepositoryAsync
	{
		private readonly DbSet<UserDetail> _userDetails;
		private readonly IIncludableQueryable<User, UserDetail> _userIncludeDetails;

		public UserDetailRepositoryAsync(UserManagementDbContext dbContext) : base(dbContext)
		{
			_userDetails = dbContext.Set<UserDetail>();
			_userIncludeDetails = dbContext.Set<User>().Include(user => user.Detail);
		}

		public async Task<IReadOnlyList<User>> GetPagedUserDetailsAsync(int pageNumber = 1, int pageSize = 10)
		{
			return await _userIncludeDetails
				.Skip((pageNumber - 1) * pageSize)
				.Take(pageSize)
				.AsNoTracking()
				.ToListAsync();
		}
	}
}
