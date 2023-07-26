using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.Domain
{
    public class TblMenu
    {

        [Key]
        public int Menucode { get; set; }

        public string? Caption { get; set; }

        public int? Parentid { get; set; }

        public int? Isparent { get; set; }
        
    }
}
