using AutoMapper;
using MediatR;
using MTS.Application.Contracts.Logging;
using MTS.Application.Contracts.Persistance;
using MTS.Application.Features.Inward.Queries.GetInwarddetails;
using MTS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.Application.Features.Calibration
{
    public class CalibarationQueryHandler : IRequestHandler<CalibrationQuery, List<TblCalibrationFrequency>>
    {
        private readonly ICalibrationRepository _calibrationRepository;

        public CalibarationQueryHandler(ICalibrationRepository calibrationRepository)
        {
            this._calibrationRepository = calibrationRepository;
        }
        public Task<List<TblCalibrationFrequency>> Handle(CalibrationQuery request, CancellationToken cancellationToken)
        {
            var datas = _calibrationRepository.GetCalibrationDatas(request.weighId);
            return datas;
        }
    }
}
