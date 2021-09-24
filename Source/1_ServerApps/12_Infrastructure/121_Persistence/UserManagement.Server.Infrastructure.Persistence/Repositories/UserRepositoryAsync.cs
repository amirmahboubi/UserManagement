using Microsoft.EntityFrameworkCore;
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
    public class UserRepositoryAsync : GenericRepositoryAsync<User>, IUserRepositoryAsync
    {
        private readonly DbSet<User> _users;

        public UserRepositoryAsync(UserManagementDbContext dbContext) : base(dbContext)
        {
            _users = dbContext.Set<User>();
        }

        public Task<bool> IsUserNameExist(string UserName)
        {
            return _users
                .AnyAsync(u => u.UserName == UserName);
        }
    }
}
