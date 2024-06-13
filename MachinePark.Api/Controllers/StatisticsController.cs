using MachinePark.Domain.Abstractions;
using MachinePark.Domain.Entities;
using MachinePark.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace MachinePark.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly IRepository<Machine> _machineRepository;

        public StatisticsController(IRepository<Machine> machineRepository)
        {
            _machineRepository = machineRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var machines = await _machineRepository.GetAsync();

            return Ok(new StatisticsDto
            {
                TotalMachines = machines.Count()
            });
        }
    }
}
