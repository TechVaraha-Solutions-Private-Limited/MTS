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
    public class GetDevicePrinterRepository : IGetDevicePrinterRepository
    {
        private readonly MtstestContext _context;

        public GetDevicePrinterRepository(MtstestContext context)
        {
            this._context = context;
        }
        public async Task<List<TblDeviceNprinter>> GetDevicePrinter()
        {
            var printers = await _context.TblDeviceNprinter.Where(u => !string.IsNullOrEmpty(u.PrinterIp)).ToListAsync();
            return printers;
        }
    }
}
