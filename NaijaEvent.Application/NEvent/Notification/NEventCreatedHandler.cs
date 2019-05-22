using MediatR;
using NaijaEvent.Application;
using NaijaEvent.Application.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;

public class NEventCreatedHandler : INotificationHandler<NEventCreated>
    {
        private readonly INotificationService _notification;

        public NEventCreatedHandler(INotificationService notification)
        {
            _notification = notification;
        }

        public async Task Handle(NEventCreated notification, CancellationToken cancellationToken)
        {
            await _notification.SendAsync(new Message());
        }

    
}

