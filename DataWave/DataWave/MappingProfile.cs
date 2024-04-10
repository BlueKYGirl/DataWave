using AutoMapper;
using Entities;
using Shared.DataTransferObjects;


namespace DataWave
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDto>()
              .ForMember(c => c.FullName,
                           opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"));
            CreateMap<UserForCreationDto, User>();
            CreateMap<Plan, PlanDto>();
            CreateMap<Device, DeviceDto>();
            CreateMap<PlanUser, PlanUserDto>();
            CreateMap<DeviceForCreationDto, Device>();
            CreateMap<User, UserDevicesDto>();
            CreateMap<PlanUserForCreationDto, PlanUser>();
        }
    }
}
