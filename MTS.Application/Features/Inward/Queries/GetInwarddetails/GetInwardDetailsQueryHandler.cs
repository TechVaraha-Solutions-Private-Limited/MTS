using AutoMapper;
using MediatR;
using MTS.Application.Contracts.Logging;
using MTS.Application.Contracts.Persistance;
using MTS.Application.Features.Menus.Queries.GetUserMenudetails;
using MTS.Application.Features.Usermaster.Queries.GetAllUsermaster;
using MTS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MTS.Application.Features.Inward.Queries.GetInwarddetails
{
    public class GetInwardDetailsQueryHandler : IRequestHandler<GetInwardDetailsQuery, List<TblQuarantine>>
    {
        private readonly IMapper _mapper;
        private readonly IInwardRepository _inwardRepository;
        private readonly IAppLogger<GetInwardDetailsQueryHandler> _logger;

        public GetInwardDetailsQueryHandler(IMapper mapper, IInwardRepository inwardRepository,
            IAppLogger<GetInwardDetailsQueryHandler> logger)
        {
            this._mapper = mapper;
            this._inwardRepository = inwardRepository;
            this._logger = logger;
        }

        public  async Task<List<TblQuarantine>> Handle(GetInwardDetailsQuery request, CancellationToken cancellationToken)
        {
            var grndetails = await _inwardRepository.GetGrnDetails(request.GrnNo);

            return grndetails;
        }
    }
}
