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
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.MachineType.Name))
                .ReverseMap();

            CreateMap<MachineCreateDto, Machine>();
            CreateMap<MachineUpdateDto, Machine>().ReverseMap();

            CreateMap<MachineType, MachineTypeDto>().ReverseMap();
        }
    }
}
