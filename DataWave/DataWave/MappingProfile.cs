﻿using AutoMapper;
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
            CreateMap<UserForCreationDto, User>() // Include Password property mapping
              .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.Password));
            CreateMap<Plan, PlanDto>();
            CreateMap<Device, DeviceDto>();
            CreateMap<PlanUser, PlanUserDto>();
            CreateMap<DeviceForCreationDto, Device>();
            CreateMap<User, UserDevicesDto>();
            CreateMap<PlanUserForCreationDto, PlanUser>();
            CreateMap<DeviceForUpdateDto, Device>().ReverseMap();
            CreateMap<SwapPhoneNumberRequestDto, Device>().ReverseMap();
            CreateMap<SwapPhoneNumberResponseDto, Device>().ReverseMap();
            CreateMap<PlanDetailDto, Plan>().ReverseMap();
            CreateMap<UserForAuthenticationDto, User>().ReverseMap();
        }
    }
}
