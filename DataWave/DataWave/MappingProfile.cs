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
        }
    }
}
