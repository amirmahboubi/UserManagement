using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Server.Core.Application.Features.Queries;
using UserManagement.Server.Core.Application.Interfaces.IFeaturesQueries;
using UserManagement.Server.Core.Application.Interfaces.IPersistenceRepositories;
using UserManagement.Server.Core.Application.Interfaces.IServices;
using UserManagement.Server.Core.Application.Services;

namespace UserManagement.Server.Core.Application
{
	public static class ServiceRegistration
	{
        public static void ConfigureApplicationServices(this IServiceCollection services)
        {
            //IFeaturesQueries
            services.AddScoped<IUserQueryService, UserQueryService>();
            services.AddScoped<IUserDetailQueryService, UserDetailQueryService>();

            //IServices
            services.AddScoped<IUserService, UserService>();
        }
    }
}
