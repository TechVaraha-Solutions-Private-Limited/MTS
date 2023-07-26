using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.Application.Features.Menus.Queries.GetUserMenudetails
{
    public class MenuDTO
    {
        public string? Caption { get; set; }
        public List<string>? ChildMenus { get; set; }
    }
}
