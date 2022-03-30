using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace MoviesManagement.Domain.POCO
{
    public class User : IdentityUser
    {
        public string Password { get; set; }

        //navigation property
        public List<Ticket> Tickets { get; set; }
    }
}
