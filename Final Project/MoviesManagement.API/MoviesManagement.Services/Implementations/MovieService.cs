using Mapster;
using MoviesManagement.Data.Repository_Interfaces;
using MoviesManagement.Domain.POCO;
using MoviesManagement.Services.Abstractions;
using MoviesManagement.Services.Exceptions;
using MoviesManagement.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MoviesManagement.Services.Implementations
{
    public class MovieService : IMovieService
    {
        private IMovieRepository _repo;

        public MovieService(IMovieRepository repo)
        {
            _repo = repo;
        }

        public async Task<List<MovieModel>> GetAllAsync()
        {
            var movies = await _repo.GetAllAsync();
            return movies.Adapt<List<MovieModel>>();
        }

        public async Task<MovieModel> GetAsync(int id)
        {
            var model =  await _repo.GetAsync(id);
            if (model == null)
                throw new MovieIsNotAvailableAtCinema("ამ დროისთვის ფილმი კინოში არ გადის");
            return model.Adapt<MovieModel>();// adapt
        }
    }
}
