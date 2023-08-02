using MTS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.Application.Features.CommonDto;


public class LogsDTO : CommonFields
{
    public int Serial_No { get; set; }
    //public DateTime? ErrDate { get; set; }
    public DateTime? ErrDate { get; set; }
    public string Form_Name { get; set; }
    public string Function_Name { get; set; }
    public string Batch { get; set; }
    public string Err_Description { get; set; }
    public string Result { get; set; }
    public string PlantCode { get; set; }
    public string IP_Address { get; set; }
    public string Username { get; set; }
    public string Application { get; set; }
    public string Status { get; set; }
}

