using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.Domain;
[Table("tblGtGWeightTransferDetails")]
public class GtGWeightTransferDetails : CommonFields
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string Quarantine { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string GtGQuarantine { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string TransferedQTY { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string UOM { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string USERID { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string GtGGRN { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string ItemCode { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string ARNOld { get; set; }
    public int AStatus { get; set; }
    [NotMapped]
    public string MaterialMovement { get; set; }
    [NotMapped]
    public string GTOG { get; set; }
}
