using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.Application.Features.Calibration.Queries.GetCalibrationData
{
    public class GetCalibrationDataQuery :IRequest<List<GetCalibrationDataDto>>
    {
        public string WeighingID { get; set; }
    }
}
