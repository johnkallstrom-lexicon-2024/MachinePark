using MachinePark.Domain.Entities;
using MachinePark.Domain.Enums;

namespace MachinePark.Persistence
{
    public class MachineParkDataStore
    {
        public List<MachineType> MachineTypes { get; set; } = default!;
        public List<Machine> Machines { get; set; } = default!;

        public MachineParkDataStore()
        {
            //LoadMachines();
            LoadMachineTypes();
        }

        private void LoadMachineTypes()
        {
            MachineTypes = new List<MachineType>
            {
                new MachineType
                {
                    Id = 1,
                    Name = "Excavator"
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
        }

        //private void LoadMachines()
        //{
        //    Machines = new List<Machine>
        //    {
        //        new Machine
        //        {
        //            Id = Guid.NewGuid(),
        //            Name = "Machine 1",
        //            Status = MachineStatus.Online,
        //            Type = new MachineType
        //            {
        //                Id = 1,
        //                Name = "Excavator",
        //            }
        //        },
        //        new Machine
        //        {
        //            Id = Guid.NewGuid(),
        //            Name = "Machine 2",
        //            Status = MachineStatus.Offline,
        //            Type = new MachineType
        //            {
        //                Id = 2,
        //                Name = "Wheel Loader",
        //            }
        //        },
        //        new Machine
        //        {
        //            Id = Guid.NewGuid(),
        //            Name = "Machine 3",
        //            Status = MachineStatus.Offline,
        //            Type = new MachineType
        //            {
        //                Id = 3,
        //                Name = "Dozer",
        //            }
        //        }
        //    };
        //}
    }
}
