using MediatR;
using MTS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.Application.Features.Calibration
{
    public class CalibrationQuery : IRequest<List<TblCalibrationFrequency>>
    {
        public string weighId { get; set; }
    }
}
