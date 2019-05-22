using AutoMapper;
using MediatR;
using NaijaEvent.Application.DTOs;
using NaijaEvent.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NaijaEvent.Application.NEvent.Query
{
    class GetNEventDetailsHandler : IRequestHandler<GetNEventDetails, NEventDTO>
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
            var result = await _unitOfWork.NEvent.FindAsync(b => b.nEventid == request.nEventId);

            return (result) ? _mapper.ProjectTo<NEventDTO>(result) : null;
        }
    }
}
