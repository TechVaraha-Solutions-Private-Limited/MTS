using MTS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.Application.Contracts.Persistance
{
    public interface IUserMenuRepository
    {
        Task<TblUsermaster> GetByUsername(string username);
        Task<List<TblMenu>> GetMenusByUserRightsAsync(string userRights);
    }
}
