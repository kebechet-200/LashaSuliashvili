using EstateManagement.Data;
using Mapster;
using Practice_1.Services.Abstractions;
using Practice_1.Services.Exceptions;
using Practice_1.Services.Models;
using Practice1.Domain.POCO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EstateManagement.Services.Implementations
{
    public class RealEstateService : IRealEstateService
    {

        private readonly IRealEstateRepository _repo;

        public RealEstateService(IRealEstateRepository repo)
        {
            _repo = repo;
        }

        public async Task<int> CreateAsync(RealEstateModel person)
        {
            var insert = person.Adapt<RealEstate>();
            var inserted = await _repo.CreateAsync(insert);
            return inserted;
        }

        public async Task DeleteAsync(int id)
        {
            if(!await _repo.Exists(id))
                throw new RealEstateNotFoundException("Real Estate could not found");

            await _repo.DeleteAsync(id);
        }

        public async Task<List<RealEstateModel>> GetAllAsync()
        {
            var result = await _repo.GetAllAsync();
            return result.Adapt<List<RealEstateModel>>();
        }

        public async Task<RealEstateModel> GetAsync(string identifier)
        {
            var result = await _repo.GetAsync(identifier);
            if (result == null)
                throw new RealEstateNotFoundException("Real Estate Could Not Found");

            return result.Adapt<RealEstateModel>();
        }

        public async Task<List<RealEstateModel>> GetFilteredAsync(int minPrice, int maxPrice)
        {
            var result = await _repo.GetFilteredAsync(minPrice, maxPrice);
            if (result == null)
                throw new RealEstateNotFoundException("Real Estate Could Not Found");

            return result.Adapt<List<RealEstateModel>>();
        }

        public async Task UpdateAsync(RealEstateModel person)
        {
            if (!await _repo.Exists(person.Id))
                throw new RealEstateNotFoundException("Real Estate Could Not Found");

            var result = person.Adapt<RealEstate>();
            await _repo.UpdateAsync(result);
        }
    }
}
