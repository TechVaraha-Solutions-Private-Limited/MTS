using Microsoft.EntityFrameworkCore;
using MTS.Application.Contracts.Persistance;
using MTS.Application.Features.Calibration.Queries.GetCalibrationData;
using MTS.Domain;
using MTS.Persistence.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.Persistence.Repositories
{
    public class GetCalibrationRepository : IGetCalibrationRepository
    {
        private readonly MtstestContext _context;

        public GetCalibrationRepository(MtstestContext context)
        {
            this._context = context;
        }

        public async Task<List<GetCalibrationDataDto>> GetCalibrationDetails(string weighId)
        {
            var data = await (from f in _context.TblCalibrationFrequency
                              join w in _context.TblCalibrationWeights on f.Id equals w.Id
                              where f.BALENCE_ID == weighId
                              select new GetCalibrationDataDto
                              {
                                  FREQTYPE = f.FREQTYPE,
                                  REPEAT_PERIOD = f.REPEAT_PERIOD,
                                  INITIAL_DUE = f.INITIAL_DUE,
                                  BALENCE_ID = f.BALENCE_ID,
                                  PId = w.Pid,
                                  Weight = w.Weight,
                                  WeighingTimes = w.WeighingTimes,
                                  AccCriteria = w.AccCriteria,
                                  MinAcc = w.MinAcc,
                                  MaxAcc = w.MaxAcc,
                                  Id = f.Id,
                                  CalDue = w.CalDue,
                                  Captured = string.Empty
                              }).ToListAsync();

            return data;
        }
    }
}
