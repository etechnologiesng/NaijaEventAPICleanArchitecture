using MediatR;
using NaijaEvent.Application.Common;
using NaijaEvent.Application.Interfaces;
using NaijaEvent.Application.NEvents.Notification;
using NaijaEvent.Domain;
using NaijaEvent.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NaijaEvent.Application.NEvents.Command.CreateEvent
{
    public class CreateEventCommandHandler : IRequestHandler<CreateEventCommand, RequestResult>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMediator _mediator;

        public CreateEventCommandHandler(IUnitOfWork unitOfWork, IMediator mediator)
        {
            _mediator = mediator;
            _unitOfWork = unitOfWork;
        }

    

        public async Task<RequestResult> Handle(CreateEventCommand request, CancellationToken cancellationToken)
        {

            try
            {
                var nEvent = new NEvent
                {
                    Description = request.Description,
                    EndDate = request.EndDate,
                    StartDate = request.StartDate,
                    EventName = request.EventName,
                    EventId = request.EventId
                };
                var result = _unitOfWork.NEvent.Add(nEvent);

                await _unitOfWork.CompleteAsync();
              await  _mediator.Publish(new NEventCreated {
                    NEventName = nEvent.EventName
                }
                );
                return await RequestResult.Success();
            }
            catch (Exception ex)
            {
                return RequestResult.Error(new Exception("There was an error creating the article", ex));
            }
        }

        
        

       
    }
}
