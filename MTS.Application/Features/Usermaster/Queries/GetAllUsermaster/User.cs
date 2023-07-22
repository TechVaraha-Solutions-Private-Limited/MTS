using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.Application.Features.Usermaster.Queries.GetAllUsermaster
{
    public class User
    {
        public string Username { get; set; } = null!;

        public string Plantcode { get; set; } = null!;

        public int? Status { get; set; }

        public string? UserRights { get; set; }

        public string? UserFullName { get; set; }
    }
}
