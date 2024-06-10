using MachinePark.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MachinePark.Persistence.EntityConfigurations
{
    public class MachineTypeConfiguration : IEntityTypeConfiguration<MachineType>
    {
        public void Configure(EntityTypeBuilder<MachineType> builder)
        {
            builder.ToTable("MachineType");

            builder.HasKey(mt => mt.Id);

            var machineTypes = new List<MachineType>
            {
                new MachineType
                {
                    Id = 1,
                    Name = "Excavator",
                },
                new MachineType
                {
                    Id = 2,
                    Name = "Wheel Loader"
                },
                new MachineType
                {
                    Id = 3,
                    Name = "Dozer"
                },
            };

            builder.HasData(machineTypes);
        }
    }
}
