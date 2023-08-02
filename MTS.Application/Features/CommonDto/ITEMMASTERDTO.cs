using MTS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.Application.Features.CommonDto
{
    public class ITEMMASTERDTO:CommonFields
    {
        public int Id { get; set; }
        public string PLANT_ITEMCODE { get; set; }
        public string SAP_ITEMCODE { get; set; }
        public string DESC { get; set; }
    }
}
