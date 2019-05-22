using AutoMapper;
using NaijaEvent.Application.DTOs;
using NaijaEvent.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace NaijaEvent.Application.Event
{
   public  class NEventProfile : Profile
    {

        public NEventProfile()
        {
            CreateMap<NEvent, NEventDTO>();
        }
    }
}
