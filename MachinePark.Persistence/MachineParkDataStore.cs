using MachinePark.Domain.Entities;
using MachinePark.Domain.Enums;

namespace MachinePark.Persistence
{
    public class MachineParkDataStore
    {
        public List<Machine> Machines { get; set; }

        public MachineParkDataStore()
        {
            Machines = new List<Machine>
            {
                new Machine
                {
                    Id = Guid.NewGuid(),
                    Name = "Machine 1",
                    Status = MachineStatus.Online,
                    Type = new MachineType
                    {
                        Id = 1,
                        Name = "Excavator",
                    }
                },
                new Machine
                {
                    Id = Guid.NewGuid(),
                    Name = "Machine 2",
                    Status = MachineStatus.Offline,
                    Type = new MachineType
                    {
                        Id = 1,
                        Name = "Wheel Loader",
                    }
                },
                new Machine
                {
                    Id = Guid.NewGuid(),
                    Name = "Machine 3",
                    Status = MachineStatus.Offline,
                    Type = new MachineType
                    {
                        Id = 1,
                        Name = "Dozer",
                    }
                }
            };
        }
    }
}
