using Microsoft.EntityFrameworkCore;
using MTS.Application.Contracts.Persistance;
using MTS.Persistence.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly MtstestContext _context;

        public GenericRepository(MtstestContext context)
        {
            _context = context;
        }
        public Task CreateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IReadOnlyList<T>> GetAsync()
        {
            /* return _context.TblUsermasters.ToListAsync();//if the return is unknown the generic 
            return type ref below code */

            //for API we no need tracking so are disabling using AsNoTracking() using in Get method
            return await _context.Set<T>().AsNoTracking().ToListAsync();
        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
