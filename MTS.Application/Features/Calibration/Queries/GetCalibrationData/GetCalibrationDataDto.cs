using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.Application.Features.Calibration.Queries.GetCalibrationData
{
    public class GetCalibrationDataDto
    {
        public string FREQTYPE { get; set; }
        public int REPEAT_PERIOD { get; set; }
        public DateTime INITIAL_DUE { get; set; }
        public string BALENCE_ID { get; set; }
        public decimal PId { get; set; }
        public double? Weight { get; set; }
        public int? WeighingTimes { get; set; }
        public string? AccCriteria { get; set; }
        public double? MinAcc { get; set; }
        public double? MaxAcc { get; set; }
        public decimal Id { get; set; }
        public DateOnly? CalDue { get; set; }
        public string Captured { get; set; }
    }
}
