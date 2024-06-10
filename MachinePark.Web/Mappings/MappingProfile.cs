using AutoMapper;
using MachinePark.Domain.Entities;
using MachinePark.Web.Features.Machines.ViewModels;

namespace MachinePark.Web.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Machine, MachineViewModel>()
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.MachineType.Name))
                .ReverseMap();

            CreateMap<MachineCreateViewModel, Machine>();

            CreateMap<MachineType, MachineTypeViewModel>().ReverseMap();
        }
    }
}
