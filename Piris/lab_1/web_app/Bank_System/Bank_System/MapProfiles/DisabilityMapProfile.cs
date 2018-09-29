using System;
using System.Collections.Generic;
using AutoMapper;
using Bank_System.Models;

namespace Bank_System.MapProfiles
{
    public class DisabilityMapProfile : Profile
    {
        [Obsolete("Create a constructor and configure inside of your profile\'s constructor instead. Will be removed in 6.0")]
        protected override void Configure()
        {
            this.CreateMap<object[], DisabilityModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src[0]))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src[1]));
        }
    }
}