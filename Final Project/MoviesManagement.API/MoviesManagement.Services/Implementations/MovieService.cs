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

        public async Task<List<MovieModel>> GetAllFullAsync()
        {
            var movies = await _repo.GetAllFullAsync();
            return movies.Adapt<List<MovieModel>>();
        }

        public async Task<MovieModel> GetAsync(int id)
        {
            var model =  await _repo.GetAsync(id);
            if (model == null)
                throw new MovieIsNotAvailableAtCinema("თქვენ მიერ არჩეული ფილმი ამ დროისთვის მიუწვდომელია");
            return model.Adapt<MovieModel>();// adapt
        }

        public async Task<MovieModel> GetFullAsync(int id)
        {
            var model = await _repo.GetFullAsync(id);
            if (model == null)
                throw new MovieIsNotAvailableAtCinema("თქვენ მიერ არჩეული ფილმი ამ დროისთვის მიუწვდომელია");
            return model.Adapt<MovieModel>();// adapt
        }
    }
}
