using Practice_1.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1.Services.Abstractions
{
    public interface IRealEstateService
    {
        Task<List<RealEstateModel>> GetAllAsync();
        Task<RealEstateModel> GetAsync(string identifier);
        Task<int> CreateAsync(RealEstateModel person);
        Task UpdateAsync(RealEstateModel person);
        Task DeleteAsync(int id);
    }
}
