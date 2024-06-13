using AutoMapper;
using MachinePark.Domain.Entities;
using MachinePark.Shared.Models;

namespace MachinePark.Api.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Machine, MachineDto>()
                .ForMember(dto => dto.Type, opt => opt.MapFrom(entity => entity.MachineType))
                .ReverseMap();

            CreateMap<MachineCreateDto, Machine>();
            CreateMap<MachineUpdateDto, Machine>().ReverseMap();

            CreateMap<MachineType, MachineTypeDto>().ReverseMap();
        }
    }
}
