﻿using AutoMapper;
using MediatR;
using NaijaEvent.Application.DTOs;
using NaijaEvent.Application.Exceptions;
using NaijaEvent.Application.Interfaces;
using NaijaEvent.Domain;
using NaijaEvent.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NaijaEvent.Application.NEvents.Query
{
  public  class GetNEventDetailsHandler : IRequestHandler<GetNEventDetails, NEventDTO>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetNEventDetailsHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<NEventDTO> Handle(GetNEventDetails request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.NEvent.FindAsync(b => b.Eventid == request.nEventId);

            return (result != null) ? _mapper.Map<NEventDTO>(result) : throw new NotFoundException(nameof(NEvent), request.nEventId);
        }
    }
}
