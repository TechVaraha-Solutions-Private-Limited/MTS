using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.Domain
{
    public class TblQuarantine
    {
       
        public decimal? REF_No { get; set; }
        [Key]
        public string? Serial_No { get; set; }
        public string? Item_Code { get; set; }
        public string? Item { get; set; }
        public string? BTNO { get; set; }
        public string? INSPLOT { get; set; }
        public string? GRNNO { get; set; }
   


       

    }
}
