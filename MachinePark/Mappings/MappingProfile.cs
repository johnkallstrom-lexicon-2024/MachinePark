using AutoMapper;
using MachinePark.Domain.Entities;
using MachinePark.ViewModels;

namespace MachinePark.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Machine, MachineViewModel>()
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type.Name))
                .ReverseMap();

            CreateMap<MachineCreateViewModel, Machine>();
        }
    }
}
