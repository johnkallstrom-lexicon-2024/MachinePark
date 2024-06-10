﻿using Microsoft.AspNetCore.Components;

namespace MachinePark.Web.Features.Machines.Components
{
    public partial class MachineCreateForm
    {
        [Parameter]
        public string? Title { get; set; }

        public MachineCreateDto Model { get; set; } = new();

        private async Task Submit()
        {
            Console.WriteLine($"Name: {Model.Name}");
            Console.WriteLine($"Status: {Model.Status}");
            Console.WriteLine($"MachineTypeId: {Model.MachineTypeId}");
        }
    }
}
