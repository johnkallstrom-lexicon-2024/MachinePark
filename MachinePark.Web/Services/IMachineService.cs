using MachinePark.Web.Features.Machines.ViewModels;

namespace MachinePark.Web.Services
{
    public interface IMachineService
    {
        IEnumerable<MachineViewModel> GetMachines();
    }
}
