using Practice1.Domain.POCO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EstateManagement.Data.EF.Repository
{
    public class RealEstateRepository : IRealEstateRepository
    {

        private IBaseRepository<RealEstate> _repo;

        public RealEstateRepository(IBaseRepository<RealEstate> repo)
        {
            _repo = repo;
        }

        public async Task<int> CreateAsync(RealEstate person)
        {
            await _repo.AddAsync(person);
            return person.Id;
        }

        public async Task DeleteAsync(int id)
        {
            await _repo.RemoveAsync(id);
        }

        public async Task<List<RealEstate>> GetAllAsync()
        {
            return await _repo.GetAllAsync();
        }

        public Task<RealEstate> GetAsync(string identifier)
        {
            return _repo.GetAsync(x => x.Identifier == identifier);
        }

        public Task<List<RealEstate>> GetFilteredAsync(int minPrice, int maxPrice)
        {
            return _repo.GetFilteredAsync(x => x.Price >= minPrice && x.Price <= maxPrice);
        }

        public async Task<bool> Exists(int id)
        {
            return await _repo.AnyAsync(x => x.Id == id);
        }

        public async Task UpdateAsync(RealEstate person)
        {
            await _repo.UpdateAsync(person);
        }
    }
}
