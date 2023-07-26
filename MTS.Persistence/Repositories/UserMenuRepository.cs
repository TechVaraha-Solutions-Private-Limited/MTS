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
    public class UserMenuRepository : IUserMenuRepository
    {
        private readonly MtstestContext _context;

        public UserMenuRepository(MtstestContext context)
        {
            _context = context;
        }

        public async Task<TblUsermaster> GetByUsername(string username)
        {
            return await _context.TblUsermaster.FirstOrDefaultAsync(u => u.Username == username);
        }

        public async Task<List<TblMenu>> GetMenusByUserRightsAsync(string userRights)
        {
            var menuItemIds = userRights.Split(',').Select(int.Parse).ToList();
            var allMenus = await _context.TblMenu.ToListAsync();
            var filteredMenus = allMenus.Where(menu => menuItemIds.Contains(menu.Menucode)).ToList();
            return filteredMenus;
        }
    }
}
