using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.Domain;



[Table("tblITEMMASTER")]
public class ITEMMASTER : CommonFields
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string PLANT_ITEMCODE { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string SAP_ITEMCODE { get; set; }
    [Column(TypeName = "varchar(MAX)")]
    public string DESC { get; set; }
}

