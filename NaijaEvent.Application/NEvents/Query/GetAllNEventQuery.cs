using MediatR;
using NaijaEvent.Application.Common;
using NaijaEvent.Application.DTOs;
using NaijaEvent.Application.NEvents.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NaijaEvent.Application.NEvents.Query
{
    public class GetAllNEventQuery : IRequest<GetListEventViewModel>
    {
        public Guid NEventId { get; set; }

    }
}
