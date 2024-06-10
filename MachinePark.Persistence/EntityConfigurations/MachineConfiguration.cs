using MachinePark.Domain.Entities;
using MachinePark.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MachinePark.Persistence.EntityConfigurations
{
    public class MachineConfiguration : IEntityTypeConfiguration<Machine>
    {
        public void Configure(EntityTypeBuilder<Machine> builder)
        {
            builder.ToTable("Machine");

            builder.HasKey(m => m.Id);

            builder
                .HasOne(m => m.MachineType)
                .WithMany(mt => mt.Machines)
                .HasForeignKey(m => m.MachineTypeId);

            var machines = new List<Machine>
            {
                new Machine
                {
                    Id = Guid.NewGuid(),
                    Name = "Machine 1",
                    Status = MachineStatus.Online,
                    MachineTypeId = 1
                },
                new Machine
                {
                    Id = Guid.NewGuid(),
                    Name = "Machine 2",
                    Status = MachineStatus.Offline,
                    MachineTypeId = 2
                },
                new Machine
                {
                    Id = Guid.NewGuid(),
                    Name = "Machine 3",
                    Status = MachineStatus.Offline,
                    MachineTypeId = 3
                },
                new Machine
                {
                    Id = Guid.NewGuid(),
                    Name = "Machine 4",
                    Status = MachineStatus.Online,
                    MachineTypeId = 1
                },
                new Machine
                {
                    Id = Guid.NewGuid(),
                    Name = "Machine 5",
                    Status = MachineStatus.Offline,
                    MachineTypeId = 2
                }
            };

            builder.HasData(machines);
        }
    }
}
