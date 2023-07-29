using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.Domain
{
    public class TblCalibrationWeights
    {
        public decimal Pid { get; set; }

        public decimal? Id { get; set; }

        public double? Weight { get; set; }

        public int? WeighingTimes { get; set; }

        public string? AccCriteria { get; set; }

        public double? MinAcc { get; set; }

        public double? MaxAcc { get; set; }

        public DateOnly? CalDue { get; set; }
     
    }
}
