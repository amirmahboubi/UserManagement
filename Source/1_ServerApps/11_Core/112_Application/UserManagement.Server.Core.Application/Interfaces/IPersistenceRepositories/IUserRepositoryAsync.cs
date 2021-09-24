using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Server.Core.Domain.Entities;

namespace UserManagement.Server.Core.Application.Interfaces.IPersistenceRepositories
{
	public interface IUserRepositoryAsync : IGenericRepositoryAsync<User>
	{
		Task<bool> IsUserNameExist(string UserName);
	}
}
