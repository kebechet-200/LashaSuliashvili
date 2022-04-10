using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesManagement.Domain.POCO
{
    public class UserRoles
    {
        public string UserName { get; set; }
        public IEnumerable<string> Roles { get; set; }
    }
}
