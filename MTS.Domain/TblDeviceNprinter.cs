using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.Domain
{
    public class TblDeviceNprinter
    {
        [Key]
        public int Id { get; set; }

        public string? DeviceIp { get; set; }

        public string? PrinterIp { get; set; }

        public string? UserName { get; set; }

        public DateTime? CrDate { get; set; }

        public string Code { get; set; } = null!;
    }
}
