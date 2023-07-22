using AutoMapper;
using MediatR;
using MTS.Application.Contracts.Logging;
using MTS.Application.Contracts.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.Application.Features.Usermaster.Queries.GetAllUsermaster
{
    public class GetAllUsermasterQueryHandler : IRequestHandler<GetAllUsermasterQuery, List<User>>
    {
        private readonly IMapper _mapper;
        private readonly IUsermasterRepository _usermasterRepository;
        private readonly IAppLogger<GetAllUsermasterQueryHandler> _logger;

        public GetAllUsermasterQueryHandler(IMapper mapper, IUsermasterRepository usermasterRepository,
            IAppLogger<GetAllUsermasterQueryHandler> logger)
        {
            _mapper = mapper;
            _usermasterRepository = usermasterRepository;
            _logger = logger;
        }
        public async Task<List<User>> Handle(GetAllUsermasterQuery request, CancellationToken cancellationToken)
        {

            //Query the Database
            var usermasters = await _usermasterRepository.GetAsync();
            //Convert data objects to DTO objects
            var data = _mapper.Map<List<User>>(usermasters);


            _logger.LogInformation("UserMaster Retreived Succesfully");
            //return list of DTO object
            return data;
        }
    }
}
