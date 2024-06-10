using MachinePark.Domain.Abstractions;
using MachinePark.Domain.Entities;
using MachinePark.Domain.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MachinePark.Services
{
    public class SelectListItemService : ISelectListItemService
    {
        private readonly IRepository<MachineType> _machineTypeRepository;

        public SelectListItemService(IRepository<MachineType> machineTypeRepository)
        {
            _machineTypeRepository = machineTypeRepository;
        }

        public List<SelectListItem> GetMachineStatuses()
        {
            var options = Enum.GetValues<MachineStatus>().Select(ms => new SelectListItem
            {
                Text = ms.ToString(),
                Value = ms.ToString()
            }).ToList();

            options.Insert(0, new SelectListItem("Choose option", string.Empty, true));

            return options;
        }

        public List<SelectListItem> GetMachineTypes()
        {
            var machineTypes = _machineTypeRepository.Get();

            var options = machineTypes.Select(mt => new SelectListItem
            {
                Text = mt.Name,
                Value = mt.Id.ToString()
            }).ToList();

            options.Insert(0, new SelectListItem("Choose option", string.Empty, true));

            return options;
        }
    }
}
