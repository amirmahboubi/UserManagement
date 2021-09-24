using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Server.Core.Domain.Entities;

namespace UserManagement.Server.Core.Application.Interfaces.IPersistenceRepositories
{
	public interface IUserDetailRepositoryAsync : IGenericRepositoryAsync<UserDetail>
	{
		Task<IReadOnlyList<User>> GetPagedUserDetailsAsync(int pageNumber = 1, int pageSize = 10);
	}
}
