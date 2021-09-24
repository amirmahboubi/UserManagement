using UserManagement.Server.Presentation.API.Middlewares;

namespace UserManagement.Server.Presentation.API.Extensions
{
	public static class ApplicationConfigureExtensions
	{
        public static void UseSwaggerExtension(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "UserManagement.Server.Presentation.API v1"));
        }

        public static void UseErrorHandlingMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ErrorHandlerMiddleware>();
        }
    }
}
