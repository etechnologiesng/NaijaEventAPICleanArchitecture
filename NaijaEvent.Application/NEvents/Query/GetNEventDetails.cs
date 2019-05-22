using MediatR;
using NaijaEvent.Application.Common;
using NaijaEvent.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace NaijaEvent.Application.NEvent.Query
{
   public class GetNEventDetails :  IRequest<NEventDTO>
    {

        public Guid nEventId { get; set; }
        public string nEventName { get; set; }
    }
}
