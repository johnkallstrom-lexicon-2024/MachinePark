using AutoMapper;
using MachinePark.Domain.Abstractions;
using MachinePark.Domain.Entities;
using MachinePark.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace MachinePark.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MachineTypesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IRepository<MachineType> _repository;

        public MachineTypesController(IRepository<MachineType> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetMachineTypes()
        {
            var machineTypes = await _repository.GetAsync();

            return Ok(_mapper.Map<IEnumerable<MachineTypeDto>>(machineTypes));
        }
    }
}
