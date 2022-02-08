using System;
using System.Collections.Generic;
using System.Text;

namespace PersonManagement.Domain.POCO
{
    public class UserPasswordReset
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
