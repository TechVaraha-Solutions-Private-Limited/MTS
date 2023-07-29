using MTS.Application.Features.Calibration.Queries.GetCalibrationData;
using MTS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.Application.Contracts.Persistance
{
    public interface IGetCalibrationRepository
    {
        Task<List<GetCalibrationDataDto>> GetCalibrationDetails(string weighId);
    }
}
