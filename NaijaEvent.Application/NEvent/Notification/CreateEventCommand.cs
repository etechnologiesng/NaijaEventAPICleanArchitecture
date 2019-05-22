using MediatR;
using System;

namespace NaijaEvent.Application
{
    public class NEventCreated : INotification
    {
        public string NEventName { get; set; }

       


    }
}
