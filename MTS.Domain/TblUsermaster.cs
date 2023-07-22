using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.Domain
{
    public class TblUsermaster
    {
        [Key]
        public string Username { get; set; } = null!;

        public string Password { get; set; } = null!;

        public string Plantcode { get; set; } = null!;

        public DateTime? Createdon { get; set; }

        public int? Status { get; set; }

        public DateTime? LastLogin { get; set; }

        public int? Logins { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public string? UserRights { get; set; }

        public string? IsAdmin { get; set; }

        public int? Expiry { get; set; }

        public DateTime? DeleteDate { get; set; }

        public string? EditedInf { get; set; }

        public string? UserFullName { get; set; }

        public int? Did { get; set; }
    }
}
