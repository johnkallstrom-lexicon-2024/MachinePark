using MachinePark.ViewModels;

namespace MachinePark.Services
{
    public interface IMachineService
    {
        IEnumerable<MachineViewModel> GetMachines();
    }
}
