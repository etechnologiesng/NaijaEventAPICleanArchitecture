using AutoMapper;
using NaijaEvent.Application.DTOs;
using NaijaEvent.Domain;
using NaijaEvent.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NaijaEvent.Application.NEvents
{
   public  class NEventProfile : Profile
    {

        public NEventProfile()
        {
            CreateMap<NEvent, NEventDTO>()
                .ForMember(a => a.EventName, c => c.MapFrom(d => d.EventName));
        }
    }
}
