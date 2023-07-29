using AutoMapper;
using MediatR;
using MTS.Application.Contracts.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.Application.Features.DevicePrinter.Queries.GetPrinterID
{
    public class GetPrinterIdQueryHandler : IRequestHandler<GetPrinterIdQuery, List<GetPrinterDto>>
    {
        private readonly IGetDevicePrinterRepository _devicePrinterRepository;
        private readonly IMapper _mapper;

        public GetPrinterIdQueryHandler(IGetDevicePrinterRepository devicePrinterRepository, IMapper mapper)
        {
            this._devicePrinterRepository = devicePrinterRepository;
            this._mapper = mapper;
        }
       

        public async Task<List<GetPrinterDto>> Handle(GetPrinterIdQuery request, CancellationToken cancellationToken)
        {
            var printers = await _devicePrinterRepository.GetDevicePrinter();
            var mapping = _mapper.Map<List<GetPrinterDto>>(printers);

            return mapping;
        }
    }
}
