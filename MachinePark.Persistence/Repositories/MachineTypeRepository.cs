﻿using MachinePark.Domain.Abstractions;
using MachinePark.Domain.Entities;
using MachinePark.Persistence.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace MachinePark.Persistence.Repositories
{
    public class MachineTypeRepository : IRepository<MachineType>
    {
        private readonly MachineParkDbContext _context;

        public MachineTypeRepository(MachineParkDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<MachineType>> GetAsync() => await _context.MachineTypes.ToListAsync();

        public Task<MachineType?> GetByIdAsync<T>(T id)
        {
            throw new NotImplementedException();
        }

        public Task<MachineType> CreateAsync(MachineType entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(MachineType entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(MachineType entity)
        {
            throw new NotImplementedException();
        }
    }
}
