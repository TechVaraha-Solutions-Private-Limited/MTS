using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.Domain;


[Table("tblLog")]
public class Log : CommonFields
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Sr { get; set; }
    public DateTime ErrDate { get; set; }
    [Column(TypeName = "varchar(100)")]
    public string Form_Name { get; set; }
    [Column(TypeName = "varchar(100)")]
    public string Function_Name { get; set; }
    [Column(TypeName = "varchar(50)")]
    public string Batch { get; set; }
    [Column(TypeName = "varchar(1000)")]
    public string Err_Description { get; set; }
    [Column(TypeName = "varchar(100)")]
    public string Result { get; set; }
    [Column(TypeName = "varchar(100)")]
    public string PlantCode { get; set; }
    [Column(TypeName = "varchar(100)")]
    public string IP_Address { get; set; }
    [Column(TypeName = "varchar(100)")]
    public string Username { get; set; }
    [Column(TypeName = "varchar(100)")]
    public string Application { get; set; }
    public string Status { get; set; }
}

