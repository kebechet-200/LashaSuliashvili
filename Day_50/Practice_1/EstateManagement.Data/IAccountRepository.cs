using Practice1.Domain.POCO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EstateManagement.Data
{
    public interface IAccountRepository
    {
        Task<Account> GetAsync(string username, string password);
        Task CreateAsync(Account account);
        Task<bool> Exists(string userName);
    }
}
