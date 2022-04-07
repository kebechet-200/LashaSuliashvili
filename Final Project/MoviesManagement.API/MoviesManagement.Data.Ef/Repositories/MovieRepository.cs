using MoviesManagement.Data.Repository_Interfaces;
using MoviesManagement.Domain.POCO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MoviesManagement.Data.Ef.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private IBaseRepository<Movie> _repo;

        public MovieRepository(IBaseRepository<Movie> repo)
        {
            _repo = repo;
        }

        public async Task<List<Movie>> GetAllAsync()
        {
            return await _repo.Table.Where(x => x.IsActive && !x.IsExpired).ToListAsync();
        }

        public async Task<List<Movie>> GetAllFullAsync()
        {
            return await _repo.Table.Include(x=> x.Tickets).ToListAsync();
        }

        public async Task<DateTime> MovieStartDate(int id)
        {
            var movie = await _repo.Table.SingleOrDefaultAsync(x => x.Id == id);
            return movie.StartDate;
        }

        public async Task<Movie> GetAsync(int id)
        {
            return await _repo.Table.SingleOrDefaultAsync(x => x.Id == id && x.IsActive && !x.IsExpired);
        }

        public async Task<Movie> GetFullAsync(int id)
        {
            return await _repo.Table.Include(x => x.Tickets).SingleOrDefaultAsync(x => x.Id == id && x.IsActive && !x.IsExpired);
        }
    }
}
