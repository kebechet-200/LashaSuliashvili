using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesManagement.Services.Models
{
    public class UserRolesModel
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public List<string> Roles { get; set; }
    }
}
