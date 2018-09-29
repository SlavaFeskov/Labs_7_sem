using System;
using AutoMapper;
using Bank_System.Models;
using Bank_System.Utils;

namespace Bank_System.MapProfiles
{
    public class ClientMapProfile : Profile
    {
        [Obsolete("Create a constructor and configure inside of your profile\'s constructor instead. Will be removed in 6.0")]
        protected override void Configure()
        {
            this.CreateMap<object[], ClientModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src[0]))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src[1]))
                .ForMember(dest => dest.SecondName, opt => opt.MapFrom(src => src[2]))
                .ForMember(dest => dest.MiddleName, opt => opt.MapFrom(src => src[3]))
                .ForMember(dest => dest.BirthDate, opt => opt.MapFrom(src => DateTime.Parse(src[4].ToString())))
                .ForMember(dest => dest.Sex, opt => opt.MapFrom(src => Enum.Parse(typeof(Sex), src[5].ToString())))
                .ForMember(dest => dest.IdNumber, opt => opt.MapFrom(src => src[6]))
                .ForMember(dest => dest.BirthPlace, opt => opt.MapFrom(src => src[7]))
                .ForMember(dest => dest.AddressFact, opt => opt.MapFrom(src => src[8]))
                .ForMember(dest => dest.HomeNumber, opt => opt.MapFrom(src => src[9]))
                .ForMember(dest => dest.WorkNumber, opt => opt.MapFrom(src => src[10]))
                .ForMember(dest => dest.EMail, opt => opt.MapFrom(src => src[11]))
                .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src[12]))
                .ForMember(dest => dest.Pensioner, opt => opt.MapFrom(src => src[13].ToString().GetBoolean()))
                .ForMember(dest => dest.MonthlyIncome, opt => opt.MapFrom(src => src[14]))
                .ForMember(dest => dest.WarBound, opt => opt.MapFrom(src => src[15].ToString().GetBoolean()))
                .ForMember(dest => dest.MaritalStatusId, opt => opt.MapFrom(src => src[16]))
                .ForMember(dest => dest.CityId, opt => opt.MapFrom(src => src[17]))
                .ForMember(dest => dest.DisabilityId, opt => opt.MapFrom(src => src[18]))
                .ForMember(dest => dest.PassportId, opt => opt.MapFrom(src => src[19]))
                .ForMember(dest => dest.CitizenshipId, opt => opt.MapFrom(src => src[20]));
        }
    }
}