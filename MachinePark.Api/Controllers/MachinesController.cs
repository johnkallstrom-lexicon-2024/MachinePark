﻿using AutoMapper;
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
    }
}
