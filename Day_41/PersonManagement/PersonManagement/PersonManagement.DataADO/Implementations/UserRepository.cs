using Microsoft.Extensions.Options;
using PersonManagement.Data;
using PersonManagement.DataADO.Models;
using PersonManagement.Domain.POCO;
using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace PersonManagement.DataADO.Implementations
{
    public class UserRepository : IUserRepository
    {
        const string SECRET_KEY = "asldij23324";
        private readonly string _connection;

        public UserRepository(IOptions<ConnectionStrings> options)
        {
            _connection = options.Value.DefaultConnection;
        }

        private string GenerateMD5Hash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] bytes = Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(bytes);

                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }

                return sb.ToString();
            }
        }

        public async Task CreateAsync(User user)
        {
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                string insertQuery = "INSERT INTO Users(FirstName, LastName, Username, Password) OUTPUT INSERTED.Id VALUES(@FirstName, @LastName, @Username, @Password)";

                SqlCommand command = new SqlCommand(insertQuery, connection);

                command.Parameters.AddWithValue("FirstName", user.FirstName);
                command.Parameters.AddWithValue("LastName", user.LastName);
                command.Parameters.AddWithValue("Username", user.Username);

                var newPass = GenerateMD5Hash(user.Password + SECRET_KEY);
                command.Parameters.AddWithValue("Password", newPass);

                connection.Open();

                var userId = (int)await command.ExecuteScalarAsync();

                ActivationEmail(userId);
            }
        }


        private void ActivationEmail(int userId)
        {
            string activationCode = Guid.NewGuid().ToString();

            using (SqlConnection connection = new SqlConnection(_connection))
            {
                string query = "INSERT INTO Accounts VALUES(@userId, @activationCode)";
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@activationCode", activationCode);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }

            using (MailMessage mm = new MailMessage("etest4202@gmail.com", "lashasuliash@gmail.com"))
            {
                mm.Subject = "Account Confirmation";
                StringBuilder sb = new StringBuilder();
                sb.Append("Hello Lasha, <br /> <br />");
                sb.Append("Please click the following link to activate your account <br />");
                sb.Append($"<a href='https://localhost:44338/api/Account/Confirmation?token={activationCode}'> Click Here To Activate Your Account.</a>");
                mm.Body = sb.ToString();
                mm.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                NetworkCredential networkCred = new NetworkCredential("etest4202@gmail.com", "TEST!@#$");
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = networkCred;
                smtp.Port = 587;
                smtp.Send(mm);
            }
        }

        private void PasswordResetEmail()
        {
            using (MailMessage mm = new MailMessage("etest4202@gmail.com", "lashasuliash@gmail.com"))
            {
                mm.Subject = "Password Changed";
                StringBuilder sb = new StringBuilder();
                sb.Append("Hello Lasha, <br /> <br />");
                sb.Append("Your Password Was Changed !!! <br />");
                mm.Body = sb.ToString();
                mm.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                NetworkCredential networkCred = new NetworkCredential("etest4202@gmail.com", "TEST!@#$");
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = networkCred;
                smtp.Port = 587;
                smtp.Send(mm);
            }
        }

        public async Task<bool> Exists(string username)
        {
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                string existQuery = "SELECT COUNT(*) FROM Users WHERE Username = @username";

                SqlCommand command = new SqlCommand(existQuery, connection);

                command.Parameters.AddWithValue("username", username);

                connection.Open();

                int count = (int)await command.ExecuteScalarAsync().ConfigureAwait(false);

                return count > 0;
            }
        }

        public async Task<User> GetAsync(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                string existQuery = "SELECT * FROM Users WHERE Username = @username AND Password = @password";

                SqlCommand command = new SqlCommand(existQuery, connection);

                command.Parameters.AddWithValue("username", username);

                var newPass = GenerateMD5Hash(password + SECRET_KEY);
                command.Parameters.AddWithValue("Password", newPass);

                connection.Open();

                SqlDataReader reader = await command.ExecuteReaderAsync();

                User user = null;

                while (await reader.ReadAsync()) // chasworeba, gava-asyncronule imedia rame ar gavafuche :D
                {
                    user = new User
                    {
                        Id = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        LastName = reader.GetString(2),
                        Username = reader.GetString(3),
                    };
                }
                reader.Close();

                return user;
            }
        }

        public async Task<bool> IsMatchToken(string token)
        {
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                string existQuery = "SELECT COUNT(*) FROM Accounts WHERE activationCode = @token";

                SqlCommand command = new SqlCommand(existQuery, connection);

                command.Parameters.AddWithValue("@token", token);

                connection.Open();

                int count = (int)await command.ExecuteScalarAsync().ConfigureAwait(false);

                return count > 0;
            }
        }

        public async Task<bool> PasswordReset(UserPasswordReset user)
        {
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                string existQuery = "SELECT Password FROM Users WHERE Password = @password";

                SqlCommand command = new SqlCommand(existQuery, connection);

                var password = Encoding.ASCII.GetBytes(user.Password);
                var updatedPasswd = GenerateMD5Hash(user.Password + SECRET_KEY);

                command.Parameters.AddWithValue("password", updatedPasswd);

                connection.Open();

                string count = (await command.ExecuteScalarAsync().ConfigureAwait(false)).ToString();

                connection.Close();

                if (updatedPasswd == count)
                {
                    if (user.NewPassword != user.ConfirmPassword)
                        return false;

                    using (SqlConnection conn = new SqlConnection(_connection))
                    {
                        string updateQuery = "UPDATE Users SET Password = @newPassword WHERE Password = @password";

                        SqlCommand cmd = new SqlCommand(updateQuery, conn);
                        user.NewPassword = GenerateMD5Hash(user.NewPassword + SECRET_KEY);
                        cmd.Parameters.AddWithValue("newPassword", user.NewPassword);
                        var newGeneratedPassword = GenerateMD5Hash(user.Password + SECRET_KEY);
                        cmd.Parameters.AddWithValue("password", newGeneratedPassword);

                        conn.Open();

                        await cmd.ExecuteNonQueryAsync();

                        PasswordResetEmail();
                    }
                    return true;
                }
                return false;
            }
        }
    }
}
