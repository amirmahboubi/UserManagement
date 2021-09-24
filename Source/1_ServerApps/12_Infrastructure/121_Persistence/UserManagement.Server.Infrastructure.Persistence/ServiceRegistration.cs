using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Server.Core.Application.Interfaces.IPersistenceRepositories;
using UserManagement.Server.Infrastructure.Persistence.Contexts;
using UserManagement.Server.Infrastructure.Persistence.Repositories;

namespace UserManagement.Server.Infrastructure.Persistence
{
	public static class ServiceRegistration
	{
        public static void AddPersistenceInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<UserManagementDbContext>(c => c.UseSqlServer(configuration.GetConnectionString(name: "UserManagementDbConnection")));

            #region Repositories
            services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));
            services.AddTransient<IUserRepositoryAsync, UserRepositoryAsync>();
            services.AddTransient<IUserDetailRepositoryAsync, UserDetailRepositoryAsync>();
            #endregion
        }
    }
}
