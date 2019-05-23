using MediatR;
using System;

namespace NaijaEvent.Application.NEvents.Notification
{
    public class NEventCreated : INotification
    {
        public string NEventName { get; set; }

       


    }
}
