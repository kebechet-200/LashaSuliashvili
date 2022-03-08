using Practice1.Domain.POCO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EstateManagement.Data
{
    public interface IRealEstateRepository
    {
        Task<List<RealEstate>> GetAllAsync();
        Task<RealEstate> GetAsync(string identifier);
        Task<int> CreateAsync(RealEstate person);

        Task<List<RealEstate>> GetFilteredAsync(int minPrice, int maxPrice);
        Task UpdateAsync(RealEstate person);
        Task DeleteAsync(int id);

        Task<bool> Exists(int id);
    }
}
