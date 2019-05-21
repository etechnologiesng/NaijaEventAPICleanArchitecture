using MediatR;
using System;

namespace NaijaEvent.Application
{
    public class CreateEventCommand : IRequest
    {
        public string EventId { get; set; }
        public string EventName { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        
        
    }
}
