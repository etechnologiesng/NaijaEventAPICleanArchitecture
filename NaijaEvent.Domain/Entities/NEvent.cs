using System;
using System.ComponentModel.DataAnnotations;

namespace NaijaEvent.Domain.Entities
{
    public class NEvent
    {  

        [Key]
        public Guid EventId { get; set; }
        public Guid Eventid { get; set; }
        public string EventName { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }





    }
}
