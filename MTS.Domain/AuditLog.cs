using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.Domain;

[Table("tblAuditLog")]
public class AuditLog : CommonFields
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID { get; set; }
    public string Log { get; set; }
    public string Comments { get; set; }
    public string TableName { get; set; }
    public string ColumnName { get; set; }
    public string OldValue { get; set; }
    public string NewValue { get; set; }
}

