namespace PersonManagement.Models.Request
{
    public class AccountPasswordResetRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
