using AutoMapper;
using MachinePark.Domain.Abstractions;
using MachinePark.Domain.Entities;
using MachinePark.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace MachinePark.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MachinesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Machine> _repository;

        public MachinesController(IRepository<Machine> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var machines = await _repository.GetAsync();

            return Ok(_mapper.Map<IEnumerable<MachineDto>>(machines));
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var machine = await _repository.GetByIdAsync(id);
            if (machine is null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<MachineDto>(machine));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] MachineCreateDto dto)
        {
            if (dto is null)
            {
                return BadRequest();
            }

            var machine = _mapper.Map<Machine>(dto);
            var createdMachine = await _repository.CreateAsync(machine);

            return CreatedAtAction(nameof(GetById), new { createdMachine.Id }, createdMachine);
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Update(Guid id, MachineUpdateDto dto)
        {
            var machine = await _repository.GetByIdAsync(id);
            if (machine is null)
            {
                return NotFound();
            }

            machine = _mapper.Map(source: dto, destination: machine);

            await _repository.UpdateAsync(machine);

            return NoContent();
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var machine = await _repository.GetByIdAsync(id);
            if (machine is null)
            {
                return NotFound();
            }

            await _repository.DeleteAsync(machine);

            return NoContent();
        }
    }
}
