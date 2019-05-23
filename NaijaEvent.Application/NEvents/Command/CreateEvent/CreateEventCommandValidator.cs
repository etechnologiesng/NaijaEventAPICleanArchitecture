using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace NaijaEvent.Application.NEvents.Command.CreateEvent
{
   public class CreateEventCommandValidator : AbstractValidator<CreateEventCommand>
    {

        public CreateEventCommandValidator()
        {
            RuleFor(x => x.EventId).NotNull();
            RuleFor(x => x.EventName).MaximumLength(60).NotEmpty();
            RuleFor(x => x.Description).MaximumLength(60).NotEmpty();
            RuleFor(x => x.StartDate).NotNull();
            RuleFor(x => x.EndDate).NotNull();

        }

       
    }
}
