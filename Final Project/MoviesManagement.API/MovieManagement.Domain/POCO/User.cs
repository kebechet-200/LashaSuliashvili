using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesManagement.Domain.POCO
{
    [NotMapped]
    public class User : IdentityUser
    {
        public string Password { get; set; }

        //navigation property
        public List<Ticket> Tickets { get; set; }
    }
}
