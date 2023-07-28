using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
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
    public class InwardRepository : IInwardRepository
    {
        private readonly MtstestContext _context;

        public InwardRepository(MtstestContext context)
        {
            this._context = context;
        }

        public async Task<List<TblQuarantine>> GetGrnDetails(string grnNo)
        {
            var inwarddetails = await _context.TblQuarantine.FromSql($"GetGrndetails {grnNo}").ToListAsync();
            //var inwarddetails =await _context.TblQuarantine.Where(u => u.GRNNO == grnNo).ToListAsync();
            return inwarddetails;
        }

       
    }
}
