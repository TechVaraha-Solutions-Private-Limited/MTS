using MTS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.Application.Features.CommonDto;


public class DeviceNPrinterDTO : CommonFields
{
    public int Id { get; set; }
    // public string DeviceIP { get; set; }
    public string PrinterIP { get; set; }
    public string UserName { get; set; }
    public DateTime? CrDate { get; set; }
    public string CODE { get; set; }
    public string StrTBL { get; set; }
}

