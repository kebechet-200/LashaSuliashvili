using MoviesManagement.Domain.POCO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MoviesManagement.Data.Repository_Interfaces
{
    public interface IMovieRepository
    {
        Task<List<Movie>> GetAllAsync();
        Task<Movie> GetAsync(int id);

        Task<Movie> GetFullAsync(int id);

        Task<List<Movie>> GetAllFullAsync();
    }
}
