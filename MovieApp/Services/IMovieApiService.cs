using MovieApp.Models;

namespace MovieApp.Services
{
    public interface IMovieApiService
    {
        Task<MovieApiResponse> SearchByTitleAsync(string title);
        Task<Models.Cinema> SearchByIdAsync(string id);
    }
}