using MTS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.Application.Contracts.Persistance
{
    public interface IInwardRepository 
    {
     
        Task<List<TblQuarantine>> GetGrnDetails(string grnNo);
    }
}
