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
            var statuses = Enum.GetValues<MachineStatus>();
            var options = statuses.Select(ms => new SelectListItem
            {
                Text = ms.ToString(),
                Value = ms.ToString()
            }).ToList();


            return options;
        }

        public List<SelectListItem> GetMachineTypes()
        {
            var types = _machineTypeRepository.Get();
            var options = types.Select(mt => new SelectListItem
            {
                Text = mt.Name,
                Value = mt.Id.ToString()
            }).ToList();

            return options;
        }
    }
}
