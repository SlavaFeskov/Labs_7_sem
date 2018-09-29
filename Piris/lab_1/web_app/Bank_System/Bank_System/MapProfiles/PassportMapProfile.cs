using System;
using System.Collections.Generic;
using AutoMapper;
using Bank_System.Models;

namespace Bank_System.MapProfiles
{
    public class PassportMapProfile : Profile
    {
        [Obsolete("Create a constructor and configure inside of your profile\'s constructor instead. Will be removed in 6.0")]
        protected override void Configure()
        {
            this.CreateMap<object[], PassportModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src[0]))
                .ForMember(dest => dest.Series, opt => opt.MapFrom(src => src[1]))
                .ForMember(dest => dest.Number, opt => opt.MapFrom(src => src[2]))
                .ForMember(dest => dest.WasGivenBy, opt => opt.MapFrom(src => src[3]))
                .ForMember(dest => dest.ReleaseDate, opt => opt.MapFrom(src => DateTime.Parse(src[4].ToString())));
        }
    }
}