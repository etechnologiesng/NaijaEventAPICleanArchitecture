using AutoMapper;
using MediatR;
using NaijaEvent.Application.Common;
using NaijaEvent.Application.DTOs;
using NaijaEvent.Application.Interfaces;
using NaijaEvent.Application.NEvents.Models;
using NaijaEvent.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NaijaEvent.Application.NEvents.Query
{
    class GetAllNEventQueryHandler : IRequestHandler<GetAllNEventQuery, GetListEventViewModel>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllNEventQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        

        }
        public async Task<GetListEventViewModel> Handle(GetAllNEventQuery request, CancellationToken cancellationToken)
        {
           var  nEvents = await _unitOfWork.NEvent.GetAll();
           return _mapper.Map<List<NEvent>, GetListEventViewModel>(nEvents.ToList());
        }
    }
}
