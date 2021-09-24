using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using UserManagement.Server.Core.Application;
using UserManagement.Server.Infrastructure.Persistence;
using UserManagement.Server.Infrastructure.Persistence.Contexts;
using UserManagement.Server.Presentation.API.Extensions;

namespace UserManagement.Server.Presentation.API
{
	public class Startup
	{
		private readonly IConfiguration _configuration;

		public Startup(IConfiguration configuration)
		{
			_configuration = configuration;
		}

		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllers();

			services.AddPersistenceInfrastructure(_configuration);
			services.AddSwaggerExtension();

			services.AddConnections();

			services.ConfigureApplicationServices();
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			app.UseSwaggerExtension();

			app.UseRouting();
			app.UseAuthorization();

			app.UseErrorHandlingMiddleware();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});

			app.UseHttpsRedirection();
		}
	}
}
