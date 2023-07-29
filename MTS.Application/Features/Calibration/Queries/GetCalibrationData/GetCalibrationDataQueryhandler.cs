using MediatR;
using MTS.Application.Contracts.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.Application.Features.Calibration.Queries.GetCalibrationData
{
    public class GetCalibrationDataQueryhandler : IRequestHandler<GetCalibrationDataQuery, List<GetCalibrationDataDto>>
    {
        private readonly IGetCalibrationRepository _calibrationRepository;

        public GetCalibrationDataQueryhandler(IGetCalibrationRepository calibrationRepository)
        {
            this._calibrationRepository = calibrationRepository;
        }
        public async Task<List<GetCalibrationDataDto>> Handle(GetCalibrationDataQuery request, CancellationToken cancellationToken)
        {
            var data = await _calibrationRepository.GetCalibrationDetails(request.WeighingID);
            return data;
        }
    }
}
