namespace UserManagement.Server.Presentation.API.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddSwaggerExtension(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new() { Title = "UserManagement.Server.Presentation.API", Version = "v1" });
            });
        }
    }

}
