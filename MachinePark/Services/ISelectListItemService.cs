﻿using Microsoft.AspNetCore.Mvc.Rendering;

namespace MachinePark.Services
{
    public interface ISelectListItemService
    {
        List<SelectListItem> GetMachineTypes();
        List<SelectListItem> GetMachineStatuses();
    }
}
