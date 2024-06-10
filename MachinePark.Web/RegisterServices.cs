using System.Reflection;

namespace MachinePark
{
    public static class RegisterServices
    {
        public static IServiceCollection AddWebServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
