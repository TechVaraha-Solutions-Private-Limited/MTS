using MediatR;
using MTS.Application.Contracts.Persistance;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.Application.Features.Menus.Queries.GetUserMenudetails
{
    internal class GetUserMenuQueryHandler : IRequestHandler<GetUserMenuQuery, List<MenuDTO>>
    {
        private readonly IUserMenuRepository _menuRepository;
        private readonly IUsermasterRepository _usermasterRepository;

        public GetUserMenuQueryHandler(IUserMenuRepository menuRepository, IUsermasterRepository usermasterRepository)
        {
            _menuRepository = menuRepository;
            this._usermasterRepository = usermasterRepository;
        }
        public async Task<List<MenuDTO>> Handle(GetUserMenuQuery request, CancellationToken cancellationToken)
        {
            var user = await _menuRepository.GetByUsername(request.Username);


            if (user == null || string.IsNullOrEmpty(user.UserRights))
            {
                return new List<MenuDTO>();
            }

            var filteredMenus = await _menuRepository.GetMenusByUserRightsAsync(user.UserRights);

            var parentMenuCodes = filteredMenus.Where(i => i.Parentid == 0).Select(m => m.Menucode).ToList();
            var childMenus = filteredMenus.Where(i => i.Parentid != 0).ToList();

            var result = new List<MenuDTO>();

            foreach (var parentMenuCode in parentMenuCodes)
            {
                var parentMenu = filteredMenus.FirstOrDefault(m => m.Menucode == parentMenuCode);
                var childMenuCaptions = childMenus
                    .Where(c => c.Parentid == parentMenuCode)
                    .Select(c => c.Caption)
                    .ToList();

                var menuDTO = new MenuDTO
                {
                    Caption = parentMenu?.Caption,
                    ChildMenus = childMenuCaptions
                };

                result.Add(menuDTO);
            }

            return result;
        }
    }
}
