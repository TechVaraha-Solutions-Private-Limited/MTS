using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.Domain
{
    public class CommonFields
    {
        public string DeviceIP { get; set; }


        public string USER { get; set; }


        public string PLANT { get; set; }


        public DateTime? CreatedOn { get; set; }


        public string CreatedBy { get; set; }


        public DateTime? ModifiedOn { get; set; }


        public string ModifiedBy { get; set; }

        //  public int TenantId { get; set; }
    }
}
