using MachinePark.Domain.Entities;
using MachinePark.Features.Machines.ViewModels;

namespace MachinePark.Services
{
    public interface IMachineTypeService
    {
        IEnumerable<MachineTypeViewModel> GetMachineTypes();
    }
}
