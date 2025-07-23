using AutoMapper;
using HandsOnAPIUsingAutoMapper.DTOs;
using HandsOnAPIUsingAutoMapper.Entities;

namespace HandsOnAPIUsingAutoMapper.Profiles
{
    public class DriverProfile:Profile
    {
        public DriverProfile()
        {
            CreateMap<DriverDto, Driver>();
            CreateMap<Driver, DriverDto>();
        }
    }
}
