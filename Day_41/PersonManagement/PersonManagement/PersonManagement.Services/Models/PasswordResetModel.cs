using System;
using System.Collections.Generic;
using System.Text;

namespace PersonManagement.Services.Models
{
    public class PasswordResetModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
