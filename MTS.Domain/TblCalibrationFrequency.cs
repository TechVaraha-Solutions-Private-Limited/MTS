using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.Domain
{
    public class TblCalibrationFrequency
    {
        [Key]
        public decimal Id { get; set; }
        public string FREQTYPE { get; set; }
        public int REPEAT_PERIOD { get; set; }
        public DateTime INITIAL_DUE { get; set; }
        public string BALENCE_ID { get; set; }

    



    }
}
