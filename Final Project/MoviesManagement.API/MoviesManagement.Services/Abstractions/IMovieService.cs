using MoviesManagement.Services.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MoviesManagement.Services.Abstractions
{
    public interface IMovieService
    {
        Task<List<MovieModel>> GetAllAsync();
        Task<MovieModel> GetAsync(int id);

        Task<MovieModel> GetFullAsync(int id);

        Task<List<MovieModel>> GetAllFullAsync();
    }
}
