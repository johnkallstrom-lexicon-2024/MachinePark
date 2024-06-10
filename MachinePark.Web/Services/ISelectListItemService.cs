using Microsoft.AspNetCore.Mvc.Rendering;

namespace MachinePark.Web.Services
{
    public interface ISelectListItemService
    {
        List<SelectListItem> GetMachineTypes();
        List<SelectListItem> GetMachineStatuses();
    }
}
