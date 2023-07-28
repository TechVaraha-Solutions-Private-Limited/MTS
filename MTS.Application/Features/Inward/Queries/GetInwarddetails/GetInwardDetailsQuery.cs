using MediatR;
using MTS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.Application.Features.Inward.Queries.GetInwarddetails
{
    public class  GetInwardDetailsQuery :IRequest<List<TblQuarantine>>
    {
        public string GrnNo { get; set; }
    }
    
}
