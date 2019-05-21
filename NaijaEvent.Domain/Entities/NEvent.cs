using System;

namespace NaijaEvent.Domain
{
    public class NEvent
    {
        public Guid EventId { get; set; }
        public string EventName { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }





    }
}
