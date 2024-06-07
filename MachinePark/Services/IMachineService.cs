using MachinePark.Features.Machines.ViewModels;

namespace MachinePark.Services
{
    public interface IMachineService
    {
        IEnumerable<MachineViewModel> GetMachines();
    }
}
