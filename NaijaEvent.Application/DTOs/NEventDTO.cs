using System;
using System.Collections.Generic;
using System.Text;

namespace NaijaEvent.Application.DTOs
{
    public class NEventDTO
    {
        public string EventId { get; set; }
        public string EventName { get; set; }
        public string Description { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

    }
}
