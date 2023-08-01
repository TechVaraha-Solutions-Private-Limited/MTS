using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.Domain;

[Table("tblDeviceNPrinter")]
public class DeviceNPrinter : CommonFields
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    // public string DeviceIP { get; set; }
    [Column(TypeName = "varchar(30)")]
    public string PrinterIP { get; set; }
    [Column(TypeName = "varchar(100)")]
    public string UserName { get; set; }
    public DateTime? CrDate { get; set; }
    [Column(TypeName = "varchar(2)")]
    public string CODE { get; set; }
    [NotMapped]
    public string StrTBL { get; set; }
}
