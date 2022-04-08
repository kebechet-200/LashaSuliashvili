using System.Collections.Generic;

namespace MoviesManagement.Admin.Models
{
    public class GetUserViewModel
    {
        public string UserName { get; set; }
        public List<string> Roles { get; set; }
    }
}
