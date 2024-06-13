using AutoMapper;
using MachinePark.Domain.Entities;
using MachinePark.Shared.Models;

namespace MachinePark.Api.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Machine, MachineDto>().ReverseMap();
            CreateMap<MachineCreateDto, Machine>();
            CreateMap<MachineUpdateDto, Machine>().ReverseMap();

            CreateMap<MachineType, MachineTypeDto>().ReverseMap();
        }
    }
}
