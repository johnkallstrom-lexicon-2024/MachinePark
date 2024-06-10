using MachinePark.Web.Features.Machines.ViewModels;

namespace MachinePark.Web.Services
{
    public interface IMachineTypeService
    {
        IEnumerable<MachineTypeViewModel> GetMachineTypes();
    }
}
