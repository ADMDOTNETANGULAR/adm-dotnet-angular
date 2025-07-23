using AutoMapper;
using HandsOnAPIUsingAutoMapper.Models;
using HandsOnAPIUsingAutoMapper.DTOs;

namespace HandsOnAPIUsingAutoMapper.MappingConfigurations
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            // Default mapping when property names are same
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();

            // Mapping when property names are different
            //CreateMap<User, UserViewModel>()
            //    .ForMember(dest =>
            //    dest.FName,
            //    opt => opt.MapFrom(src => src.FirstName))
            //    .ForMember(dest =>
            //    dest.LName,
            //    opt => opt.MapFrom(src => src.LastName));
        }
    }

}
