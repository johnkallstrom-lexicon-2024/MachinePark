using MachinePark.Domain.Entities;
using MachinePark.Web.Services;
using System.Reflection;

namespace MachinePark
{
    public static class RegisterServices
    {
        public static IServiceCollection AddWebServices(this IServiceCollection services)
        {
            services.AddScoped<IMachineService, MachineService>();
            services.AddScoped<IMachineTypeService, MachineTypeService>();
            services.AddScoped<ISelectListItemService, SelectListItemService>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
