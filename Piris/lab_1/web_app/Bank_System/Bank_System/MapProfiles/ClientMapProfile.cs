using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Bank_System.Domain.DbModels;
using Bank_System.Models;

namespace Bank_System.MapProfiles
{
    public class ClientMapProfile : Profile
    {
        protected override void Configure()
        {
            this.CreateMap<ClientDbModel, ClientModel>();
        }
    }
}