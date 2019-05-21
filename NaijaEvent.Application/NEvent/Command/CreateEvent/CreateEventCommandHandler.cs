using MediatR;
using NaijaEvent.Application.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NaijaEvent.Application.Event.Command.CreateEvent
{
    public class CreateEventCommandHandler : IRequestHandler<CreateEventCommand>
    {
        public Task<Unit> Handle(CreateEventCommand request, CancellationToken cancellationToken)
        {

            try
            {

            }
            throw new NotImplementedException();
        }
    }
}
