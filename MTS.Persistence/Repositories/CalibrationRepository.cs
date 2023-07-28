using Microsoft.EntityFrameworkCore;
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
    public class CalibrationRepository : ICalibrationRepository
    {
        private readonly MtstestContext _context;

        public CalibrationRepository(MtstestContext context)
        {
            this._context = context;
        }

       

        public async Task<List<TblCalibrationFrequency>> GetCalibrationDatas(string weighId)
        {
            var datas = await _context.TblCalibrationFrequency.ToListAsync();
            return datas;
        }
    }
}
