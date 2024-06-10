using MachinePark.Domain.Abstractions;
using MachinePark.Domain.Entities;
using MachinePark.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace MachinePark.Persistence
{
    public static class RegisterServices
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services)
        {
            services.AddSingleton<MachineParkDataStore>();
            services.AddScoped<IRepository<Machine>, MachineRepository>();
            services.AddScoped<IRepository<MachineType>, MachineTypeRepository>();

            return services;
        }
    }
}
