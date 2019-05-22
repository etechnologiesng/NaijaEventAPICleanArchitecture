using MediatR;
using NaijaEvent.Application.Common;
using System;

namespace NaijaEvent.Application
{
    public class CreateEventCommand : IRequest<RequestResult>
    {
        public Guid EventId { get; set; }
        public string EventName { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        
        
    }
}
