﻿using MoviesTelegramBotApp.Models;

namespace MoviesTelegramBotApp.Interfaces
{
    public interface IMovieService
    {
        Task<int> CountAsync { get; }
        Task<List<Movie>> GetAllMoviesAsync(int moviePage = 1);
        Task<List<Movie>> GetMoviesByTitleAsync(string searchString, int moviePage);
        Task<int> GetMoviesByTitleCountAsync(string searchString);
        Task<Movie> GetRandomMovieAsync();
        Task<List<Movie>> GetMoviesByGenreAsync(string genre);
        Task<List<Genre>> GetAllGenresAsync();
    }
}
