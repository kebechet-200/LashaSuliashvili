using Practice1.Domain.POCO;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EstateManagement.Data.EF.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private IBaseRepository<Account> _repo;

        public AccountRepository(IBaseRepository<Account> repo)
        {
            _repo = repo;
        }

        public async Task CreateAsync(Account account)
        {
            await _repo.AddAsync(account);
        }

        public async Task<bool> Exists(string userName)
        {
            return await _repo.AnyAsync(x => x.Username == userName);
        }

        public async Task<Account> GetAsync(string username, string password)
        {
            return await _repo.Table.SingleOrDefaultAsync(x => x.Username == username && x.Password == password);
        }
    }
}
