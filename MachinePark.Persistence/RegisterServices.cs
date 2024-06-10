using MachinePark.Domain.Abstractions;
using MachinePark.Domain.Entities;
using MachinePark.Persistence.DbContexts;
using MachinePark.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MachinePark.Persistence
{
    public static class RegisterServices
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<MachineParkDataStore>();
            services.AddDbContext<MachineParkDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("Default"));
            });

            services.AddScoped<IRepository<Machine>, MachineRepository>();
            services.AddScoped<IRepository<MachineType>, MachineTypeRepository>();

            return services;
        }
    }
}
