using MTS.Application.Contracts.Persistance;
using MTS.Domain;
using MTS.Persistence.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.Persistence.Repositories
{
    public class UsermasterRepository : GenericRepository<TblUsermaster>, IUsermasterRepository
    {
        public UsermasterRepository(MtstestContext context) : base(context)
        {
        }
    }
}
